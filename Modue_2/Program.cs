
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using Modue_2;
using Modue_2.DbModel;
using Modue_2.DTOs;

string path = @"d:\tmp\file1.txt";

/*
Console.WriteLine(File.Exists(path));
Console.WriteLine( Path.GetFileName(path) );
Console.WriteLine( Path.GetFileNameWithoutExtension(path) );
Console.WriteLine( Path.GetPathRoot(path) );
*/
var path2 = Path.Combine(@"c:", "dir1", "system", "back-end", "screen.scr");

//Console.WriteLine(path2);

for (int i = 0; i < 10; ++i)
{
    var res = Path.GetRandomFileName();
    //Console.WriteLine(res);
}

//Console.WriteLine(Path.GetTempPath());


string file = @"d:\tmp\sample1.txt";
/*
using (FileStream fs = File.Create(file)) 
{
    AddText(fs, "This is some text");
    AddText(fs, "This is more text");
    AddText(fs, "\nthis is a new line of text");
}
*/
/*
using (var fs = File.OpenRead(file))
{
    var b = new byte[1024];
    var t = new UTF8Encoding(true);

    while (fs.Read(b, 0, b.Length) > 0)
    {
        Console.WriteLine(t.GetString(b));
    }
}
*/
/*
if(File.Exists(file))
{
    File.Delete(file);
}
*/
string json = @"d:\tmp\json.txt";
string json2 = "json2.json";

string result = ReadFromFile(json2);
/*
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

var obj = JsonSerializer.Deserialize<Top>(result, options);
obj.Print();
string xml_file = "data.xml";

ToXmlFile(obj, xml_file);
*/

Top objFromXml = FromXmlFile<Top>("data.xml");

//Console.WriteLine("Object form Xml file:");
// objFromXml.Print();

// Console.WriteLine(result);

List<Shape> shapes = new List<Shape> { 
    new Rectangle {  Color = "Blue", Height = 6, Width = 2 },
    new Square { Color = "Black", Size = 5},
    new Rectangle { Color = "Red", Height = 7, Width = 2 }
};


ToXmlFile(shapes, "shapes.xml");


List<Shape> shapesFromXml = FromXmlFile<List<Shape>>("shapes.xml");

foreach (Shape shape in shapesFromXml)
{
    //Console.WriteLine(shape.Name + " " + shape.Color + " " + shape.Area);
}

/*
var obj = FromXmlFile<Customers>("customers.xml");

foreach (var item in obj.customers)
{
    Console.WriteLine($"{item.name} {item.creditcard} {item.password}");
}
*/

/*
// Console.WriteLine(DataProtector.GenerateSecretKey());
string secretKey = @"GSLeW257L43U7J@qpwNV\s10jhlu<kAy";


var customers = new List<Customer> {
        new Customer 
        { 
            Name = "Bob Smith", 
            Creditcard = DataProtector.EncryptString(secretKey, "1234-5678-9012-3456"), 
            Password = DataProtector.SaltAndHash("Pa$$w0rd") 
        } 
};

ToXmlFile(customers, "customers_from_code.xml");


var customersFromFile = FromXmlFile<List<Customer>>("customers_from_code.xml");

foreach (var item in customersFromFile)
{
    string cc = DataProtector.DecryptString(secretKey, item.Creditcard);
    Console.WriteLine($"{item.Name} {cc} {item.Password}");

    Console.WriteLine(item.Password == DataProtector.SaltAndHash("Pa$$w0rd"));
}
*/



var employees = new List<Modue_2.Sample.Employee> { 
    new Modue_2.Sample.Employee { Id = 101, FirstName = "Mark", LastName = "Smith", Salary = 2500 }, 
    new Modue_2.Sample.Employee { Id = 102, FirstName = "Lucy", LastName = "Swanson", Salary = 2700 }, 
    new Modue_2.Sample.Employee { Id = 103, FirstName = "Tracy", LastName = "Johnson", Salary = 2400 }, 
    new Modue_2.Sample.Employee { Id = 104, FirstName = "John", LastName = "Doe", Salary = 2550 }, 
};

string binary_file = "Employee2.dat";

ToBinary(employees, binary_file);
var employee_from_binary = FromBinary<List<Modue_2.Sample.Employee>>(binary_file);

foreach (var item in employee_from_binary)
{
    Console.WriteLine(item);
}



string employee_json = "Employee.json";
// ToJson(employees, employee_json);
var employees_from_json = FromJson<List<Modue_2.Sample.Employee>>(employee_json);


string employee_xml = "Employees.xml";
ToXmlFile(employees, employee_xml);

foreach (var item in employees_from_json)
{
    Console.WriteLine(item);
}

northwindContext context = new northwindContext();

/*
var employees_from_db = context.Employees.ToList();

foreach (var item in employees_from_db)
{
    Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName + " " + item.Address);
}

ToXmlFile(employees_from_db, "result.xml");
ToJson(employees_from_db, "result.json");
ToBinary(employees_from_db, "result.dat");
*/

var employees_from_db = context.Employees
    .Select(x => new EmployeeDto { 
        Id = x.Id,
        FirstName = x.FirstName,
        LastName = x.LastName,
        Address = x.Address,
        City = x.City,
        Attachments = x.Attachments,
        BusinessPhone = x.BusinessPhone,
        Company = x.Company,
        CountryRegion = x.CountryRegion,
        EmailAddress = x.EmailAddress,
        FaxNumber = x.FaxNumber,
        HomePhone = x.HomePhone,
        JobTitle = x.JobTitle,
        MobilePhone = x.MobilePhone,
        Notes = x.Notes,
        StateProvince = x.StateProvince,
        WebPage = x.WebPage,
        ZipPostalCode = x.ZipPostalCode
    }).ToList();

ToXmlFile(employees_from_db, "result.xml");
ToJson(employees_from_db, "result.json");
ToBinary(employees_from_db, "result.dat");


List<SerializedFile> fileList = new List<SerializedFile>() { 
    new SerializedFile { 
        Name = "result.xml",
        Size = new FileInfo("result.xml").Length
    },
    new SerializedFile {
        Name = "result.dat",
        Size = new FileInfo("result.dat").Length
    },
    new SerializedFile {
        Name = "result.json",
        Size = new FileInfo("result.json").Length
    },

};

fileList.Sort();

Console.WriteLine("========== Ranked files ============");

foreach (var item in fileList)
{
    Console.WriteLine(item.Name + " has  b" + item.Size);
}


/*
List<int> ints = new List<int> {12, 4 , 25, 6};
ints.Sort();
Console.WriteLine(string.Join(",", ints));
*/


static T FromBinary<T>(string binary_file)
{
    using (Stream st = File.OpenRead(binary_file))
    {
        BinaryFormatter bf = new BinaryFormatter();
        return (T)bf.Deserialize(st);
    }
}

static void ToBinary<T>(T obj, string binary_file)
{
    using (Stream st = File.Open(binary_file, FileMode.Create))
    {
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(st, obj);
    }
}

static void ToJson<T>(T obj, string path)
{
    string json = JsonSerializer.Serialize(obj);
    File.WriteAllText(path, json);
}

static T FromJson<T>(string path)
{
    string json = File.ReadAllText(path);
    return JsonSerializer.Deserialize<T>(json);
}

static T FromXmlFile<T>(string path)
{
    string xml = File.ReadAllText(path);
    using (StringReader sr = new StringReader(xml))
    {
        XmlSerializer xmls = new XmlSerializer(typeof(T));
        return (T)xmls.Deserialize(sr);
    }
}

static void ToXmlFile<T>(T obj, string path)
{
    using (StringWriter sw = new StringWriter(new StringBuilder()))
    { 
        XmlSerializer xmls = new XmlSerializer(typeof(T));
        xmls.Serialize(sw, obj);
        File.WriteAllText(path, sw.ToString());
    }
}


static string? ReadFromFile(string file_path)
{
    if (File.Exists(file_path))
    {
        return File.ReadAllText(file_path);
    }
    Console.WriteLine("File is not exists");
    return null;
}


static void AddText(FileStream fs, string line)
{
    var info = new UTF8Encoding().GetBytes(line);
    fs.Write(info, 0, info.Length);
}

