using System;

namespace CSharp09._12
{
    internal class Program
    {
        public static void Main()
        {
            int[] numbers = { -1, 0, 1, 2, 3 };
            string query = "ABCD";

            Subject[] subjects = new Subject[3];
            
            for (int i = 0; i < 3; i++)
            {
                int number = numbers[i + 1];
                switch (number)
                {
                    case -1:
                        subjects[i] = new RealSubject();
                        break;
                    case 0:
                        subjects[i] = new Proxy(false, false);
                        break;
                    case 1:
                        subjects[i] = new Proxy(true, false);
                        break;
                    case 2:
                        subjects[i] = new Proxy(false, true);
                        break;
                    case 3:
                        subjects[i] = new Proxy(true, true);
                        break;
                }
            }
            
            foreach (Subject subject in subjects)
            {
                Console.WriteLine("Subject: " + subject.GetType().Name);
                foreach (char queryChar in query)
                {
                    switch (queryChar)
                    {
                        case 'A':
                            Console.WriteLine("Request A: " + subject.RequestA());
                            break;
                        case 'B':
                            Console.WriteLine("Request B: " + subject.RequestB());
                            break;
                        case 'C':
                            Console.WriteLine("Request C: " + subject.RequestC());
                            break;
                        case 'D':
                            Console.WriteLine("Request D: " + subject.RequestD());
                            break;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}