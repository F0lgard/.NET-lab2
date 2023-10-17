﻿using WebApplication1.Entities;
using WebApplication1.Entities;

namespace WebApplication1.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}