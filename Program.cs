using System.Data;
using System.Diagnostics;

namespace الصيدليه1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number of medicine

            int NumberOfMedicine = GetNumberOfMedicine();

            // store names & prices & numbers in arrys 

            string[] names = new string[NumberOfMedicine];
            double[] Brices = new double[NumberOfMedicine];
            double[] numbers = new double[NumberOfMedicine];

            DataEntry(NumberOfMedicine, names, Brices, numbers);

            //space

            space();

            // welcome user

            Welcome();

            //if medicine Existing in arry and sum total

            IfMedicineExistingInArry(NumberOfMedicine, names, Brices, numbers);

            Console.ReadKey();
        }

        static void IfMedicineExistingInArry(int NumberOfMedicine, string[] names, double[] Brices, double[] numbers)
        {
            double SumMedicine = 0;
            char LoopIndex = 'a';
            while (LoopIndex != 'e')
            {
                print("enter the type of medicine required ");
                string medicine = Console.ReadLine();

                for (int x = 0; x < NumberOfMedicine; x++)
                {
                    if (medicine == names[x])
                    {
                        double Brice = Brices[x];
                        Console.WriteLine("the price =  " + Brice);
                        SumMedicine += Brice;
                        numbers[x]--;

                        NumberValid(numbers, x);
                    }
                    else
                    {
                        continue;
                    }
                }
                print("for exisit press \" e \" else press any key");
                LoopIndex = char.Parse(Console.ReadLine());

            }

            //turn SumMedicine;
            Console.Write("the total medicine price ");
            Console.WriteLine(SumMedicine + " EGP");
        }


        static void Welcome()
        {
            print("welcome to the pharmacy program ");
        }
        static void DataEntry(int NumberOfMedicine, string[] names, double[] Brices, double[] numbers)
        {

            // make the loop for ask names & price & number

            for (int i = 1; i <= NumberOfMedicine; i++)
            {
                print("enter the name of medicine number " + i);
                string NameOfMedicine = Console.ReadLine();

                print("enter the Brice of medicine number " + i);
                double BriceOfMedicine = double.Parse(Console.ReadLine());

                print("enter the numbers of medicine number " + i);
                double NumbersOfMedicine = double.Parse(Console.ReadLine());

                //store data in arrys

                names[i - 1] = NameOfMedicine;
                Brices[i - 1] = BriceOfMedicine;
                numbers[i - 1] = NumbersOfMedicine;

            }
        }

        static void NumberValid(double[] number1, int a)
        {
            if (number1[a] <= 0)
            {
                print1("This medicien does not exist ");
            }
        }
        static int GetNumberOfMedicine()
        {
            int NumberOfMedicine;

            do
            {
                // Ask about the number of medicine
                print("How many medicine? ");

                // input the number of medicine
                NumberOfMedicine = GetInt();

            } while (NumberOfMedicine <= 0);

            return NumberOfMedicine;

        }

        static void print(string s)
        {

            Console.WriteLine(s);
            Console.WriteLine("---------------------------------------");

        }
        static void print1(string s)
        {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine(s);
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

        }
        static void space()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t     ************");
            Console.WriteLine("\n \n \n ");

        }
        static int GetInt()
        {
            string S = Console.ReadLine();
            int value = int.Parse(S);
            return value;
        }


    }
}


