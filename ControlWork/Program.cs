namespace VladimirArtamnov
{
    public static class ControlWorkFirstBlock
    {
        /*
        Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых
        меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатиры, либо задать на старте выполнения алгоритма.
        При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
        Примеры:
        ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
        ["1234", "1567", "-2", "computer science"] -> ["-2"]
        ["Russia", "Denmark", "Kazan"] -> []
        */

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк, которые будут храниться в массиве:");
            int strLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 1, если хотите вводить строки вручную или 2, если сделать их случайным выбором:");
            int selectOption = Convert.ToInt32(Console.ReadLine());
            string[] arrayStringFirst = new string[strLength];
            int counter = 0;
            switch (selectOption)
            {
                case 1:
                    counter = ManualInputStrings(arrayStringFirst);
                    break;
                case 2:
                    counter = RandomInputStrings(arrayStringFirst);
                    break;
                default:
                    Console.WriteLine("Вы не ввели нужного варианта!");
                    break;
            }
            //string[] arrayStringResult = new string[counter];
            //arrayStringResult = arrayStringFirst.Where(i => i.Length < 4).ToArray();
            string[] arrayStringResult = FindThreeElementsString(arrayStringFirst, counter);
            Console.WriteLine("Входящий массив строк [" + string.Join(", ", arrayStringFirst) + "]");
            Console.WriteLine("Итоговый массив строк с строками не более или равные 3 символам [" + string.Join(", ", arrayStringResult) + "]");

        }

        public static int ManualInputStrings(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} строку:\t");
                array[i] = Convert.ToString(Console.ReadLine());
                if (array[i].Length <= 3)
                {
                    count++;
                }
            }
            return count;

        }
        public static int RandomInputStrings(string[] array)
        {
            const string charsData = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz#@$^*()";
            int count = 0;
            int randomLengthString;
            for (int i = 0; i < array.Length; i++)
            {
                randomLengthString = new Random().Next(1, 7);
                if (randomLengthString <= 3)
                {
                    count++;
                }
                for (int j = 0; j <= randomLengthString; j++)
                {
                    int randomPosition = new Random().Next(0, 69);
                    array[i] += charsData[randomPosition];
                }

            }
            return count;
        }
        public static string[] FindThreeElementsString(string[] arrayIn, int countOfString)
        {
            int lengthStr;
            int j = 0;
            string[] arrayOut = new string[countOfString];
            for (int i = 0; i < arrayIn.Length; i++)
            {
                lengthStr = Convert.ToInt32(arrayIn[i].Length);
                if (lengthStr <= 3)
                {
                    arrayOut[j] = arrayIn[i];
                    j++;
                }

            }
            return arrayOut;
        }



    }
}
