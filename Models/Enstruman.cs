using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models;

public abstract class Enstruman
{
    public  Enstruman(string? brand, string? model, decimal price)
    {
        Id = Guid.NewGuid();
        Brand = brand;
        Model = model;
        Price = price;
    }

    public Guid Id { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public decimal Price { get; set; }

    public abstract void DefaultSes();
}

public class Piano : Enstruman
{
    public string? Length { get; set; }
    
    public Piano(string? length, string? brand, string? model, decimal price) : base(brand, model, price)
    {
        Id = Guid.NewGuid();
        Length = length;
    }

    public override void DefaultSes()
    {
        Console.WriteLine("Piano sesi");
    }
    public override string ToString()
    {
        return base.Brand;
    }
}

public class Kenam : Enstruman
{
    public Kenam(string? arse, string? brand, string? model, decimal price) : base(brand, model, price)
    {
        Id = Guid.NewGuid();
        this.Arse = arse;
    }

    public string Arse { get; set; }
    public override void DefaultSes()
    {
        Console.WriteLine("Keman -))))");
    }
    public override string ToString()
    {
        return base.Brand;
    }
}

public class Gitar : Enstruman
{
    public Gitar(string? magneticArray, string? brand, string? model, decimal price) : base(brand, model, price)
    {
        Id = Guid.NewGuid();
        this.MagneticArray = magneticArray;
    }

    public string MagneticArray { get; set; }
    public override void DefaultSes()
    {
        Console.WriteLine("Gitar sound -))))");
    }
    public override string ToString()
    {
        return base.Brand;
    }
}

public class Flute : Enstruman
{
    public Flute(string? material, string? brand, string? model, decimal price) : base(brand, model, price)
    {
        Id = Guid.NewGuid();
        this.Material = material;
    }

    public string Material { get; set; }
    public override void DefaultSes()
    {
        Console.WriteLine("Flute sound -))))");
    }
    public override string ToString()
    {
        return base.Brand;
    }
}

public class Muzisyen
{
    public Muzisyen(string? firstName, string? lastName, Enstruman alet)
    {
        FirstName = firstName;
        LastName = lastName;
        this.alet = alet;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Enstruman alet { get; set; }
}