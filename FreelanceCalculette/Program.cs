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
    else { Console.WriteLine("Montant invalide. Veuillez entrer un nombre valide.");
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
Console.WriteLine("Vous êtes à " + (plafond - totalBrut) +  " euros du plafond");   
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


// CORRECTION DU PROF

//Console.WriteLine("Bienvenue dans mon application de comptabilité pour Freelance !");
//Console.WriteLine("");
//Console.WriteLine("");

////Voici comment récupérer les valeurs de toutes les factures
//Console.WriteLine("Entrez les valeurs de vos factures, puis tapez STOP quand vous avez fini.");
//List<int> allFactures = new List<int>();
//bool continueAsking = true;
//do
//{
//    bool isOk = false;
//    do
//    {
//        string reponseString = "";
//        try
//        {
//            //on récupére une facture
//            Console.WriteLine("Quel est la valeur TTC de votre facture ?");
//            reponseString = Console.ReadLine();
//            int reponse = Convert.ToInt32(reponseString);
//            allFactures.Add(reponse);
//            isOk = true;
//        }
//        catch (Exception ex)
//        {
//            continueAsking = !string.Equals(reponseString, "STOP", StringComparison.CurrentCultureIgnoreCase);
//            if (continueAsking)
//            {
//                Console.WriteLine("Entrée incorrecte, veuillez rééssayer");
//                isOk = false;
//            }
//            else
//            {
//                isOk = true;
//            }
//        }
//    }
//    while (!isOk);
//}
//while (continueAsking);


//int CABrut = allFactures.Sum();
//decimal CANet = Convert.ToDecimal(CABrut * 0.75);
//decimal Plafond = 36800;

//Console.WriteLine($"CA Brut Annuel : {CABrut}");
//Console.WriteLine($"CA Net Annuel: {CANet}");
//Console.WriteLine($"CA Brut Mensuel: {getMensual(CABrut)}");
//Console.WriteLine($"CA Net Mensuel: {getMensual(CANet)}");


//Console.WriteLine($"Vous êtes à {Plafond - CABrut} € du plafind");

//Console.WriteLine("Tapez sur n'importe quelle touche pour quitter l'application.");
//Console.ReadLine();

//static decimal getMensual(decimal annualSum)
//{
//    return annualSum / 12;
//}