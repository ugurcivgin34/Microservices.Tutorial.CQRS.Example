﻿namespace Microservices.Tutorial.CQRS.Example.Models
{
    public static class ApplicationDbContext
    {
        public static List<Product> ProductList { get; set; } = new();
    }
}
