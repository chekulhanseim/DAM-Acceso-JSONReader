using System;
using System.IO;
using JSONReader.Models;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSONReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos!");

            var jsonString = File.ReadAllText("config.json");
           
            var appModel = JsonSerializer.Deserialize<Aplicacion>(jsonString);

            Console.WriteLine("Has iniciado la aplicacion con las siguientes parametros:");
            Console.WriteLine("NOMBRE: {0}, YEAR: {1} ", appModel.Nombre, appModel.Year);

        }
    }
}
