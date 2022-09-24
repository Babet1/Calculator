using System;

namespace Kalkulator
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            float angka1;
            float angka2 ;
            int operasi;
            float hasil ;
            float Hasil;
            


           Console.WriteLine("Enter the action to be performed");
           Console.WriteLine("---------------------------------");
           Console.WriteLine("Press 1 for Addition");
           Console.WriteLine("Press 2 for Substraction");
           Console.WriteLine("Press 3 for Multiplication");
           Console.WriteLine("Press 4 for Division");

           operasi = int.Parse(Console.ReadLine());

        
            Console.Write("Enter 1st Input = ");
            angka1 = float.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Input = ");
            angka2 = float.Parse(Console.ReadLine());


             if (operasi == 1)
           {
            hasil = angka1 + angka2;
            
           }
            else if (operasi == 2)
           {
            hasil = angka1 - angka2;
            Console.WriteLine($"The result is {hasil}");
           }
            else if (operasi == 3)
           {
            hasil = angka1 * angka2;
            Console.WriteLine($"The result is {hasil}");
           }
            else if (operasi == 4)
           {
            hasil =  angka1 / angka2;
            Console.WriteLine($"The result is {hasil}");
           }
            else 
           {
            Console.WriteLine("Operation eror!");
           }
           

           
            
        }
    }
}