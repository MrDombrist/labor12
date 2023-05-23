using labor12;
using StackExem;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

class Demo
{
    static void Main(string[] args)
    {
        // task 1 a,b,c
        //string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\test.txt";
        //StreamReader sr = new StreamReader(path);
        //string[] str = sr.ReadToEnd().Split('\n');
        //StackEx<(string, string)> stack = new StackEx<(string, string)>(str.Length);
        //for (int i = 0; i < str.Length; i++)
        //{
        //    stack.Push((str[i], stack.isEmpty ? str[i] : P(str[i],stack)));
        //    Console.WriteLine("string: "+ stack.Peek().Item1);
        //    Console.WriteLine("Min:   " + stack.Peek().Item2);
        //}
        //int j = 0;
        //while (str[j] != stack.Peek().Item2)
        //{
        //    j++;
        //}
        //Console.WriteLine("min - " + stack.Peek().Item2+"\nindex - "+ j+"\nlenght - "+ str[j].Length);

        //string P(string str, StackEx<(string,string)> a)
        //{
        //        if (str.Length > a.Peek().Item2.Length)
        //        {
        //            return a.Peek().Item2;
        //        }
        //        return str;
        //}



        // task 1 d
        //string path = @"C:\Users\rusla\source\repos\labor10\labor10\bin\basedir\data\test.txt";
        //StreamReader sr = new StreamReader(path);
        //string[] str = sr.ReadToEnd().Split('\n');
        //Stack<(string, string)> stack = new Stack<(string, string)>(str.Length);
        //for (int i = 0; i < str.Length; i++)
        //{
        //    stack.Push((str[i], stack.Count==0 ? str[i] : P(str[i], stack)));
        //    Console.WriteLine("string: " + stack.Peek().Item1);
        //    Console.WriteLine("Min:   " + stack.Peek().Item2);
        //}
        //int j = 0;
        //while (str[j] != stack.Peek().Item2)
        //{
        //    j++;
        //}
        //Console.WriteLine("min - " + stack.Peek().Item2 + "\nindex - " + j + "\nlenght - " + str[j].Length);

        //string P(string str, Stack<(string, string)> a)
        //{
        //    if (str.Length > a.Peek().Item2.Length)
        //    {
        //        return a.Peek().Item2;
        //    }
        //    return str;
        //}

        //task 2

        //static bool CheckBrackets(string input)
        //{
        //    var stack = new StackEx<char>();

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char c = input[i];

        //        if (c == '(' || c == '[' || c == '{')
        //        {
        //            stack.Push(c);
        //        }
        //        else if (c == ')' || c == ']' || c == '}')
        //        {
        //            if (stack.Count() == 0)
        //            {
        //                Console.WriteLine(i + 1);
        //                return false;
        //            }

        //            char top = stack.Pop();
        //            if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
        //            {
        //                Console.WriteLine(i + 1);
        //                return false;
        //            }
        //        }
        //    }

        //    if (stack.Count() > 0)
        //    {
        //        Console.WriteLine(input.IndexOf(stack.Peek()) + 1);
        //        return false;
        //    }

        //    return true;
        //}

        //string input = Console.ReadLine();
        //if (CheckBrackets(input))
        //{
        //    Console.WriteLine("YES");
        //}


        //task 3 a1
        //Console.WriteLine("Введите строку:");
        //string[] str = Console.ReadLine().Split('\n');
        //var queue = new QueueOfString<string>(str.Length);
        //Regex regex = new Regex("[A-Z]");
        //for (int i = 0; i < str.Length; i++)
        //{
        //    if (regex.IsMatch(str[i].ToString()))
        //    {
        //        queue.Enqueue(str[i].ToString());
        //    }
        //    else
        //    {
        //        if (queue.Count==0)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            if (str[i].ToString() == "*")
        //            {
        //                Console.WriteLine(queue.Dequeue);//не смог разобраться с выводом, почему выводит System:(
        //            }
        //        }
        //    }
        //}

        //task 3 a2

        //Console.WriteLine("Введите строку:");
        //string[] str = Console.ReadLine().Split('\n');
        //Regex regex = new Regex("[A-Z]");
        //Queue<string> queue = new Queue<string>();
        //for (int i = 0; i < str.Length; i++)
        //{
        //    if (regex.IsMatch(str[i].ToString()))
        //    {
        //        queue.Enqueue(str[i].ToString());
        //    }
        //    else
        //    {
        //        if (queue.Count == 0)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            if (str[i].ToString() == "*")
        //            {
        //                Console.WriteLine(queue.Dequeue());
        //            }
        //        }
        //    }
        //}


        //task 3 b1


    }
}