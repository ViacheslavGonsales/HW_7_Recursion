// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

namespace Tasks
{
    static class Program
    {
        public static void Main (string [] args)
        {
            System.Console.WriteLine("Задача 3: Задайте произвольный массив. Выведете его элементы,");
            System.Console.WriteLine("начиная с конца. Использовать рекурсию, не использовать циклы.");
            int [] array = CreateArray(10,10,0);
            System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
            System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array,array.Length-1))}]");
        }

        public static int [] CreateArray (int size, int max, int min){
            int [] array  = new int[size];
            Random rand = new();
            for (int i = 0; i < size; i++)
            {
                array [i] = rand.Next(min,max+1);
            }
            return array;
        }
        public static void PrintArray(char [,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string output = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    output += array[i,j] + " ";
                }
                System.Console.WriteLine($"[ {output}]");
                output = "";
            }
        }
        public static string PrintArray(int [] array)
        {
            return string.Join(", ",array);
        }
        public static int [] ArraySwap(int [] array,int index)
        {

            if (index <= 0)
            {
                return array;
            }
            int temp = array[index];
            array[index] = array[array.Length - index-1];
            array[array.Length - index-1] = temp;
            return ArraySwap(array,index -= 2);
        }
    }
}

