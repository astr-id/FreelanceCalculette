decimal totalBrut = 0;
string reponse;

while (true)
{
    Console.WriteLine("Entrez le montant de vos factures. Entrez STOP une fois que vous avez terminé");
    reponse = Console.ReadLine();

    if (reponse == "STOP")
    {
        break;
    }
    if (decimal.TryParse(reponse, out decimal montant))
    {
        totalBrut += montant;
    }
    else
    {
        Console.WriteLine("Montant invalide. Veuillez entrer un nombre valide.");
    }
}

decimal totalNet = totalBrut * 0.75m;
decimal plafond = 36800;

Console.WriteLine("Brut Annuel : " + totalBrut + " euros");
Console.WriteLine("Net Annuel : " + totalNet + " euros");
Console.WriteLine("Brut Mensuel : " + getMensual(totalBrut) + " euros");
Console.WriteLine("Net Mensuel : " + getMensual(totalNet) + " euros");

if (totalBrut < plafond)
{
    Console.WriteLine("Vous êtes à " + (plafond - totalBrut) + " euros du plafond");
}
else
{
    Console.WriteLine("Attention ! Vous dépassez le plafond de " + (totalBrut - plafond) + " euros du plafond");
}

Console.WriteLine("Tapez sur n'importe quelle touche pour quitter l'application.");
Console.ReadLine();

static decimal getMensual(decimal total)
{
    return total / 12;
}