// using System;

// public class EncapsulationTester{

//     private int energy = 10;
//     private int mood = 10;

//     public int swag = 100;


//     public void PrintEnergy(){
//         System.Console.WriteLine("ENERGY:    "+energy);
//     }

//     static void Main(){
//         System.Console.WriteLine("GOOD MORNING KARAN");
//         EncapsulationTester etr = new EncapsulationTester();
//         ChildClass cls = new ChildClass();
//         cls.PrintEnergy();
//         cls.GetAndPrintSwag();
//     }

// }

// public class ChildClass : EncapsulationTester{
//     public void GetAndPrintSwag(){
//         Console.WriteLine(base.swag);
//     }
// }