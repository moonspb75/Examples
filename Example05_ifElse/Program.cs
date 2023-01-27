Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "мария")
{
    Console.WriteLine("Ура, это же МАРИЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}