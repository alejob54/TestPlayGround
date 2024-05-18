// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using TestPlayGround;
using TestPlayGround._98._Study;



//CustomLinkedList.LinkedList<int> linkedList = new CustomLinkedList.LinkedList<int>();
//// Add some elements to the linked list

//int i = 1;
//while (linkedList.Count() < 100)
//{
//    linkedList.Add(i);
//    i++;
//}

//// Print the linked list
//linkedList.Print();



//QUEUE EXAMPLE

//Console.WriteLine("Add a message ? (y/n)");
//Collections collections = new();

//var key = Console.ReadLine();
//while (key.ToLower() == "y")
//{
//    Console.WriteLine("(A)dd message / (R)emove message / (C)lear messages / (L)ist all");
//    var key2 = Console.ReadLine();
//	switch (key2.ToLower())
//	{
//		case "a":
//            Console.WriteLine("Type a message");
//            string msj = Console.ReadLine();
//            collections.AddMessage(new Collections.MessageStruct() { Id = collections.Count() + 1, Message = msj });
//            break;
//        case "r":
//            collections.RemoveMessage();
//            break;
//        case "c":
//            collections.ClearMessages();
//            break;
//        case "l":
//            collections.Print();
//            break;
//        default:
//            break;
//    }

//    Console.WriteLine("Continue ? (y/n)");
//    key = Console.ReadLine();
//}

//Console.WriteLine("Bye");


// Stack Example
//StackExample stackExample = new StackExample();
//stackExample.DoWork();

//HashTableExamples hash =  new HashTableExamples();
//hash.DoWork();


Solution solution = new Solution();
solution.TwoSum(new int[] { 3, 2, 4 }, 6);