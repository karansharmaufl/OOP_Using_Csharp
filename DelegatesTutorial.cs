// using System;
// using System.Threading;

// namespace Csharp
// {
//     class DelegatesTutorial
//     {

//         delegate int AddOne(int i);


//         public static int incByOne(int num){
//             return num+1;
//         }
//         static void Main(string[] args)
//         {
//             AddOne a1 = new AddOne(incByOne);
//             int p = a1(25);
//             Console.WriteLine("Hello World!"+p);
//         }
//     }
// }
