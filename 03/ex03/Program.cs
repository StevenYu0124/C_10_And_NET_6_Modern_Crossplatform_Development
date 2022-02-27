for (int i = 1; i <= 100; i++){
    bool reminder3 = i % 3 == 0;
    bool reminder5 = i % 5 == 0;

    if (reminder3 && reminder5){
        Console.Write("FizzBuzz, ");
    }
    else if (reminder3){
        Console.Write("Fizz, ");
    }
    else if (reminder5){
        Console.Write("Buzz, ");
    }
    else{
        Console.Write($"{i}, ");
    }
}