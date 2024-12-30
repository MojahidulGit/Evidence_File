using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultyTask_Asynchronous
{
    internal class Program
    {
        private static void Create_Task_Using_Action()
        {
            Console.WriteLine("This Task is Created Using Action.\n");
        }

        private static void Create_Task_Using_Delegate()
        {
            Console.WriteLine("This Task is created using Delegate.\n");
        }

        private static void CreateTaskUsingLambdaAndNamedMethod()
        {
            Console.WriteLine("This Task is created using Lambda and Named Method.\n");
        }

        private static void CreateTaskUsingLambdaAndAnonymousMethod()
        {
            Console.WriteLine("This Task is created using Lambda and Anonymous Method.\n");
        }

        private static void CreateTaskUsingAsyncAwait()
        {
            Console.WriteLine("This Task is created using Async and Await.\n");
        }

        private static async void CreateAsyncTask()
        {
            await Task.Run(() => CreateTaskUsingAsyncAwait());
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }
        private static async void SolveTheMath(int firstInt, int secondtInt)
        {
            int result = await Task.FromResult(Add(firstInt, secondtInt));
            await Task.Delay(1000);
            Console.WriteLine("Result = " + result.ToString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Seven ways to start a Task in C# .NET:");
            Console.WriteLine("=====================================\n");

            //Creating a Task using Factory Method
            Task.Factory.StartNew(() => { Console.WriteLine("This Task is created using Factory Method.\n"); });

            //Creating a Task using Action
            Task actionTask = new Task(new Action(Create_Task_Using_Action)); 
            actionTask.Wait(1000);
            actionTask.Start();

            //Creating a Task using Delegate.
            Task delegateTask = new Task(delegate { Create_Task_Using_Delegate(); }); 
            delegateTask.Wait(1000);
            delegateTask.Start();

            //Creating a Task using Lambda and Named Method.
            Task lambdaAndNamedMethodTask = new Task(() => CreateTaskUsingLambdaAndNamedMethod()); 
            lambdaAndNamedMethodTask.Wait(1000);
            lambdaAndNamedMethodTask.Start();

            //Creating a Task using Lambda and Anonymous Method.
            Task lambdaAndAnonymousMethodTask = new Task(() => { CreateTaskUsingLambdaAndAnonymousMethod(); }); 
            lambdaAndAnonymousMethodTask.Wait(1000);
            lambdaAndAnonymousMethodTask.Start();

            //Creating a Task using Async and Await.
            CreateAsyncTask(); 
            Console.Write("\nFirst Integer = ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Second Integer = ");
            int secondtInt = int.Parse(Console.ReadLine());

            //Creating a Task using FromResult Method.
            SolveTheMath(firstInt, secondtInt); 

            Console.Read();
        }
    }

}
  