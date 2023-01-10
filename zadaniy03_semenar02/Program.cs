Console.WriteLine("Введите число дня недели");
int x = Convert.ToInt32(Console.ReadLine());

if ( x > 5 && x < 8 ) Console.WriteLine("Выходной день недели");

if ( x > 0 && x < 6 ) Console.WriteLine("Будничный день недели");
