using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WA4_Qn4
{
    class Operation
    {
        public void SumThread()
        {
            Thread add = new Thread(() => { AddThread(); });
            add.Start();
        }

        private void AddThread()
        {
            throw new NotImplementedException();
        }

        public int AddThread(int FirstNumber, int SecondNumber)
        {
            int addresult = FirstNumber + SecondNumber;
            Console.WriteLine("The sum of {0} and {1} is {2}" , FirstNumber, SecondNumber, addresult);
            return addresult;
            
        }

        public void MinusThread()
        {
            Thread minus = new Thread(() => { SubtractThread(); });
            minus.Start();
        }

        private void SubtractThread()
        {
            throw new NotImplementedException();
        }

        public int SubtractThread(int FirstNumber, int SecondNumber)
        {
            int subresult = FirstNumber - SecondNumber;
            Console.WriteLine("The subtraction of {0} and {1} is {2}", FirstNumber, SecondNumber, subresult);
            return subresult;

        }

        public void TimesThread()
        {
            Thread times = new Thread(() => { MultiplyThread(); });
            times.Start();
        }

        private void MultiplyThread()
        {
            throw new NotImplementedException();
        }

        public int MultiplyThread(int FirstNumber, int SecondNumber)
        {
            int multiplyresult = FirstNumber * SecondNumber;
            Console.WriteLine("The multiplication of {0} and {1} is {2}", FirstNumber, SecondNumber, multiplyresult);
            return multiplyresult;
        }

        public void DivisionThread()
        {
            Thread divide = new Thread(() => { DivideThread(); });
            divide.Start();
        }

        private void DivideThread()
        {
            throw new NotImplementedException();
        }

        public int DivideThread(int FirstNumber, int SecondNumber)
        {
            int divideresult = FirstNumber / SecondNumber;
            Console.WriteLine("The division of {0} and {1} is {2}", FirstNumber, SecondNumber, divideresult);
            return divideresult;
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            bool continue_calculate = true;
           while (continue_calculate)
            {
                int FirstNumber;
                Console.Write("\nInput the First Number : ");
                FirstNumber = int.Parse(Console.ReadLine());

                int SecondNumber;
                Console.Write("\nInput the Second Number : ");
                SecondNumber = int.Parse(Console.ReadLine());

                Operation op = new Operation();

                Calculate:
                Console.WriteLine("Choose Operation: ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Remainder");
                Console.WriteLine("6. Power");

                int choose;
                choose = int.Parse(Console.ReadLine());


                switch (choose)
                {
                    case 1:
                        {
                            op.SumThread();
                            break;
                        }
                    case 2:
                        {
                            op.MinusThread();
                            break;
                        }
                    case 3:
                        {
                            op.TimesThread();
                            break;
                        }
                    case 4:
                        {
                            op.DivisionThread();
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input. Enter a number from 1 to 6");
                            goto Calculate;
                        }
                }

            }

            End:
            Console.WriteLine("\n Do you want end program? Yes or No");
            string quit = Console.ReadLine();
            quit.ToUpper();
            if(quit == "YES" )
            {
                continue_calculate = false;
            }
        }
    }
}
