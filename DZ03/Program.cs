Console.WriteLine("Введи цифру, обозначающую день недели: ");
int daynum = Convert.ToInt32 (value: Console.ReadLine());

if (daynum == 6 ^ daynum == 7) 
{
  Console.WriteLine("да (это выходной день)");
}
  else 
    if (daynum < 1 ^ daynum > 7) 
  {
    Console.WriteLine("это не день недели");
  }
  else 
{
  Console.WriteLine("нет (это не выходной день)");
}
