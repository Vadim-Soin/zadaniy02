Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int n = N;
if (N<= 99) Console.WriteLine("Третей цифры нет");
else    
    {
        while (N > 999)
        {
            N = N / 10;
        }
    int result = N % 10;
    Console.WriteLine($"{result} Является третей цифрой числа {n}");
    }  
    