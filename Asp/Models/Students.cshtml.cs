using System;
using System.Collections.Generic;

namespace AspCore.Models
{
    public class StudentsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Classes { get; set; }
        public DateTime JoinDate { get; set; }
    }
}