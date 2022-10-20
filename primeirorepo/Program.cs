

Console.WriteLine("-----------------------");
Console.WriteLine("1- Saudações");
Console.WriteLine("-----------------------");

Console.WriteLine("Escolha uma opção: ");
int opc = Convert.ToInt32(Console.ReadLine());

if (opc == 1)
{
    Console.WriteLine("Qual o seu nome?");
    string nome= Console.ReadLine();

    Console.WriteLine($"Olá, {nome} !!!");
}
