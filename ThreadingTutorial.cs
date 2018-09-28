// using System;
// using System.Threading;

// namespace Csharp{

//     // Threading helps us to share data and resources without corrupting them

//     public class ThreadingTutorial{


        

//         public static void Main(){
//             //Console.WriteLine("In this tutorial");

//             Thread t = new Thread(Print1);

//             t.Start();

//             for(int i=0;i<1000;i++){
//                 System.Console.Write(0);
//             }

//             Console.ReadLine();

//         }   

//         static void Print1(){
//             for(int i=0;i<1000;i++){
//                 System.Console.Write(1);
//             }
//         }
//     }
// }