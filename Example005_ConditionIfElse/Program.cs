Console.Write("Введите пожалуйста имя пользователя: ");
string username = Console.ReadLine();

if(username == "Гайк")
{
    Console.WriteLine("Ура, как я рад тебя видеть, дорогой Гайк!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}