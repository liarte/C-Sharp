using System;

namespace Matrix
{
    class Program
    {
        public static void addMatrix(string[,] matrix, int row, int col, int num)
        {

            string[,] orderMatrix = new string[row, col];


            Console.WriteLine("enter how many matrix are going to make: ");
            int entermatrix = 0;
            for (int i = 0; i < entermatrix; i++)
            {
                Console.WriteLine("How many rows:");
                for (int rowEnter = 0; rowEnter < row; rowEnter++)
                {
                    Console.WriteLine("How many columns: ");
                    for (int colsEnter = 0; colsEnter < col; colsEnter++)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int option;

        do
        {
            Console.WriteLine("1.-Add Matrix");
            Console.WriteLine("2.-Subtract Matrix");
            Console.WriteLine("3.-Multiply Matrix");
            Console.WriteLine("4.-Transfixed Matrix");
            Console.WriteLine("5.-Diagonal Matrix");
            Console.WriteLine("6.-High Matrix");
            Console.WriteLine("7.-Reverse Matrix");
            Console.WriteLine("8.-Inverted Matrix");
            Console.WriteLine("9.-Inverse Matrix");
            //Console.WriteLine("10.- Matrix");
            Console.WriteLine("0.-Exit");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 0:
                    break;

                case 1:
                    //addMatrix();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    Console.WriteLine("Option not avaliable");
                    break;
                default:
                    Console.WriteLine("Unknown option");
                    break;
            }
        }
        while (option != 0);
    }
}
