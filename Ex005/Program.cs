// УРА, это же МАША!

Console.Clear();

Console.WriteLine("Введите имя пользователя: ");
string? username = Console.ReadLine();

if (String.IsNullOrEmpty(username))
{
    Console.WriteLine("Имя пользователя не введено");
}
else
{
    if (username.ToLower() == "маша")
    {
        Console.WriteLine("УРА, это же МАША!");
    }
    else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }
}