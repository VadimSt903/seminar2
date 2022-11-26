Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32 (value: Console.ReadLine());
if(num < 100)
{
    Console.WriteLine("Нет третьего числа");
}
else 
{  
    for(; num >= 1000; num /= 10);  

    Console.WriteLine(num % 10);
}


