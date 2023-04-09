Console.WriteLine("Введите первое число (a):");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число (b):");
        int b = int.Parse(Console.ReadLine());

        
        if (a>b) {
            Console.WriteLine("наибольшее число ="+ (a));
        } else {
            Console.WriteLine("наибольшее число ="+ (b));
        }