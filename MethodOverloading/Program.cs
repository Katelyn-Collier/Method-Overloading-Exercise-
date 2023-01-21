namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }

        }
        public static void Main(string[] args)
        {
            var x = 12;
            var y = 83;

            var answer = Add(x, y);

            var a = 13.33m;
            var b = 77.77m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(1, 2, true);

            Console.WriteLine($"int add:{answer} decimal add:{decimalAnswer}");

            Console.WriteLine(thirdAnswer);
        }
    }
}
