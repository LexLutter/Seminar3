    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) number = number * (-1);
    if (number >= 10000 & number < 100000){
        int first = number / 10000;
        int last = number % 10;
        if (first == last){
            first = (number / 1000) % 10;
            last = (number % 100) / 10;
            Console.WriteLine($"Введенное вами число является полиндромом.");
        }
        else Console.WriteLine($"Введенное вами число не является полиндромом.");
    }
    else Console.WriteLine($"Вы ввели некорректное число.");
    
