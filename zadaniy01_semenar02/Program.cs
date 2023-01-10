
Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());
int n = N;
if (N<= 9) Console.WriteLine("Второй цифры нет");
else    
    {
        while (N > 99)
        {
            N = N / 10;
        }
    int result = N % 10;
    Console.WriteLine($"{result} Является второй цифрой числа {n}");
    }  
