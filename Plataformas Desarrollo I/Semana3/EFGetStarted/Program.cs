using EFGetStarted.Models;
using System;
using System.Linq;
namespace EFGetStarted
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var db=new DataBaseContext())
      {
        // Create
        Console.WriteLine("Inserting a new Persona");
        db.Add(new Models.Persona { Id = 1002, Nombres = "Marco Vinicio", Identificacion = "1721481586" });
        db.Add(new Models.Persona { Id = 1003, Nombres = "Sebastian Lituma", Identificacion = "1709292829" });
        db.Add(new Models.Persona { Id = 1004, Nombres = "Miguel Narvaez", Identificacion = "0920282911" });
        db.SaveChanges();

        // Read
        Console.WriteLine("Querying for a blog");
        var persona = db.Personas.OrderBy(b => b.Id).First();

        // Update
        Console.WriteLine("Updating the blog and adding a post");
        persona.Nombres = "Marco Antonio Ayala Lituma";
        db.SaveChanges();

        // Delete
        Console.WriteLine("Delete the blog");
        db.Remove(persona);
        db.SaveChanges();
      }
    }
  }
}
