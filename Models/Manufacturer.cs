﻿namespace DefectiveProduct.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CNPJ { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public int isActive { get; set; }

    }
}