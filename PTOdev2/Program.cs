namespace PTOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generated random number must be unique (ÖDEV) random gelen sayılar birbirini tekrar etmemeli

            Console.WriteLine("how many numbers do you want to sort?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("enter starting number:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter end number:");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("generated number :");
            Console.WriteLine("\n");
            Random rnd = new Random();

            int[] numbers = new int[count];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = rnd.Next(start, end);
                bool unique = true;


                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    numbers[i] = number;
                }
                else
                {
                    i--;
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}