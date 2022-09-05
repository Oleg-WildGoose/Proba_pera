Console.WriteLine("Введите имя, путник");
string user = Console.ReadLine();

if (user.ToLower() == "маша")
{
    Console.WriteLine("Аве Мария!");
}
else 
{
    Console.Write("Привет тебе путник - ");
    Console.WriteLine(user);
}
