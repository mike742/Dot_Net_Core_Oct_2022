﻿using System;
using System.Collections.Generic;

namespace Modue_2.DbModel
{
    public partial class SalesReport
    {
        public string GroupBy { get; set; } = null!;
        public string? Display { get; set; }
        public string? Title { get; set; }
        public string? FilterRowSource { get; set; }
        public bool Default { get; set; }
    }
}
