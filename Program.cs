using System;
using System.Collections.Generic;

namespace Stek11
{
    public class Node<T>
    {
        public T value { get; }
        public Node<T> _next { get; private set; }
        public Node(T value, Node<T> lowerNode)
        {
            this.value = value;
            _next = lowerNode;
        }
        public void ChangePointer(Node<T> lowerNode)
        {
            _next = lowerNode;
        }
    }
    public class stackFixed<T>
    {
        private Node<T> top;
        public stackFixed()
        {
            top = new Node<T>(default(T), null);
        }
        public void Push(T value)
        {
            top = new Node<T>(value, top);
        }
        public T Pop()
        {
            var result = top.value;
            top = top._next;
            return result;
        }
        public T Peek()
        {
            return top.value;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            char exitCheck = 'n';
           stackFixed<string> stackFixed = new stackFixed<string>();
            while (exitCheck != 'y')
            {
                Console.WriteLine("Enter command name ");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "0": //добавление


                       
                        Console.WriteLine("Enter Pop item");
                        string inputer = Console.ReadLine();
                        stackFixed.Push(inputer);
                        Console.WriteLine("Current Peek is :");
                        Console.WriteLine(stackFixed.Peek());
                        Console.WriteLine("---------------------------------------------------");
                        break;

                    case "1": //вывод всех файлов стека
                        Console.WriteLine("---------------------------------------------------");
                        
                        Console.WriteLine("---------------------------------------------------");
                        break;

                    case "2"://удалене файла

                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Current Peek is :");
                        Console.WriteLine(stackFixed.Peek());
                        Console.WriteLine();
                        Console.WriteLine("Eraising element from the top");
                        stackFixed.Pop();
                        Console.WriteLine();
                        Console.WriteLine("Current Peek is :");
                        Console.WriteLine(stackFixed.Peek());
                        Console.WriteLine("---------------------------------------------------");
                        break;

                }

            }
            Console.ReadLine();
        }
    }


}
