using DZ_4_1;


AbstractHandler handler = null;
Console.WriteLine("Впишіть формат документа (XML, TXT, DOC): ");
string format = Console.ReadLine().ToUpper();
switch (format)
{
    case "XML":
        handler = new XMLHandler();
        break;
    case "TXT":
        handler = new TXTHandler();
        break;
    case "DOC":
        handler = new DOCHandler();
        break;
    default:
        Console.WriteLine("Недійсний формат");
        return;
}
handler.Open();
handler.Create();
handler.Change();
handler.Save();

Console.ReadLine();
