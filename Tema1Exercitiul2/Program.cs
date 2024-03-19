using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex2
    /*Ex2
Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura*/

{ public class Program
    { public static void Main(string[] args)
        { 
          double primulNumar;
          double alDoileaNumar;
          double alTreileaNumar; 
          double mediaAritmetica; 
          Console.WriteLine("Introduceti primul numar: ");
          primulNumar = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Introduceti al doilea numar: ");
          alDoileaNumar = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Introduceti al treilea numar: ");
          alTreileaNumar = Convert.ToDouble(Console.ReadLine()); 
          mediaAritmetica = (primulNumar + alDoileaNumar + alTreileaNumar) / 3; 
          Console.WriteLine($"Media aritmetica a numerelor {primulNumar} , {alDoileaNumar} si {alTreileaNumar} este {mediaAritmetica}");
        } 
    }
}
