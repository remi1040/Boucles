// See https://aka.ms/new-console-template for more information

String[] moves = new String[32];

for (int i = 0; i < moves.Length; i++)
{
    Console.WriteLine("Entrez un pas de danse: "); 
    string userEntry = Console.ReadLine();
    if (userEntry == "done")
    {
        break;
    }
    else
    {
        moves[i] = userEntry;
    }
}

Console.WriteLine("Entrez un nombre de répétition: ");
string nombre_de_pas = Console.ReadLine();

int number1 = Convert.ToInt32(nombre_de_pas);



for (int i = 0; i < number1; i++) {
    foreach (string move in moves)
    {
        Console.Write(move + " ");
    }
    Console.WriteLine();
    
}
