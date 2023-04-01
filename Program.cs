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
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("<=============================>");
}





Console.WriteLine("|====== Decomposição Decimais ======|");

Console.Write("Digite a quantidade: ");
int numero = Convert.ToInt32(Console.ReadLine());
int restante = numero;

int unidades = restante % 10;
restante = restante / 10;

int dezenas = restante % 10;
restante /= 10;
int centenas = restante;
Console.WriteLine($"|O número possui: {Convert.ToString(numero).PadRight(18,'.').Substring(0,1)} Unidades |");
Console.WriteLine($"|O número possui: {Convert.ToString(numero).PadRight(18,'.').Substring(1,1)} Dezenas |"); 
Console.WriteLine($"|O número possui: {Convert.ToString(numero).PadRight(18,'.').Substring(2,Convert.ToString(numero).Length-2)} Centenas |");