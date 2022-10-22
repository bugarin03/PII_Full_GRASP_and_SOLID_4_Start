//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Functions functions = Functions.Instancer;
            Recipe recipe = new Recipe();

            functions.AddProductToCatalog("Café", 100);
            functions.AddProductToCatalog("Leche", 200);
            functions.AddProductToCatalog("Café con leche", 300);

            functions.AddEquipmentToCatalog("Cafetera", 1000);
            functions.AddEquipmentToCatalog("Hervidor", 2000);

            recipe.FinalProduct = functions.GetProduct("Café con leche");
            recipe.AddStep(functions.GetProduct("Café"), 100, functions.GetEquipment("Cafetera"), 120);
            recipe.AddStep(functions.GetProduct("Leche"), 200, functions.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }
    }
}
