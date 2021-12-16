List<string> languageList = new List<string>();
// Ajouté manuel d'éléments dans la liste
languageList.Add("HTML");
languageList.Add("CSS");
languageList.Add("Javacrit");
languageList.Add("jQuery");
languageList.Add("PHP");
languageList.Add("Bootstrap");
languageList.Add("Java");
// Affichage de la liste
foreach (var item in languageList)
{
    Console.WriteLine(item);
}
// Affichage d'éléments de la liste
Console.WriteLine();
Console.WriteLine($"Voici le 4ème élément de la liste : {languageList[3]}.");
Console.WriteLine();
Console.WriteLine($"Voici l’élément à l’index 4 de la liste : {languageList[4]}.");
Console.WriteLine();
// Modification de la liste
languageList.Remove("Bootstrap");
languageList[languageList.IndexOf("Javacrit")] = "Javascript";
languageList.Add("C");
// Affichage de la liste
Console.WriteLine($"Affichage de toute la liste. La liste a été modifiée.");
foreach (var item in languageList)
{
    Console.WriteLine(item);
}