class Program{
    public static void Main(string[] args){
        int number1;
        int number2;

        Console.WriteLine("Enter a number between 0 and 255: ");
        string? numberString = Console.ReadLine();
        if (!ValidateStringToInt(numberString, out number1)){
            return;
        }
        Console.WriteLine("Enter another number between 0 and 255: ");
        numberString = Console.ReadLine();
        if (!ValidateStringToInt(numberString, out number2)){
            return;
        }
        if (number2 == 0){
            Console.WriteLine($"can not devide by 0");
            return;
        }
        Console.WriteLine($"{number1} devide by {number2} is {number1/number2}");
    }

    private static bool ValidateStringToInt(string? numberString, out int number){
        number = default;
        if (numberString == null){
            Console.WriteLine($"Empty input");
            return false;
        }
        if (!int.TryParse(numberString, out number)){
            Console.WriteLine("Invalid integer format");
            return false;
        }
        if (number < 0 || number > 255){
            Console.WriteLine("Invalid integer range: Number should be between 0 and 255");
            return false;
        }
        return true;
    }
}

