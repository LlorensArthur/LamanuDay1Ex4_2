List<string> languageList = new List<string>();
languageList.Add("HTML");
languageList.Add("CSS");
languageList.Add("Javacrit");
languageList.Add("jQuery");
languageList.Add("PHP");
languageList.Add("Bootstrap");
languageList.Add("Java");
foreach (var item in languageList)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine(languageList[3]);
Console.WriteLine();
Console.WriteLine(languageList[4]);
Console.WriteLine();
languageList.Remove("Bootstrap");
languageList[languageList.IndexOf("Javacrit")] = "Javascript";
languageList.Add("C");
foreach (var item in languageList)
{
    Console.WriteLine(item);
}