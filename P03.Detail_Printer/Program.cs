using System.Collections.Generic;
using System;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            var employee = new Employee("Pesho");
            var manager = new Manager("Gosho", new[] { "Doc 0", "Doc 1"});
            var detailsPrinter = new DetailsPrinter(new List<Employee>(new[] { employee, manager }));
            detailsPrinter.PrintDetails();
        }
    }
}
