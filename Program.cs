void Shin (int fun)
{
     if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
}


void barra()
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("<=============================>");
}



Console.Clear();
Shin(00);
Console.WriteLine("<=== Decomposição Decimais ===>");
Shin(01);
Console.Write("Digite a quantidade: ");
int numero = Convert.ToInt32(Console.ReadLine());
int unidades = numero % 10;
numero = numero / 10;

int dezenas = numero % 10;
numero /= 10;
int centenas = numero;
barra();
Shin(02);
Console.WriteLine($"|O número possui: {Convert.ToString(unidades).PadLeft(2,'.')} Unidades |");
Console.WriteLine($"|O número possui: {Convert.ToString(dezenas).PadLeft(2,'.')}  Dezenas |"); 
Console.WriteLine($"|O número possui: {Convert.ToString(centenas).PadRight(2,'.')} Centenas |");
barra();
Console.ResetColor();
