using DZ_4_2;

Player player = new Player();

Console.WriteLine("Впишіть хочете ви записувати чи програвати музику (Playing,Recording):");
string played = Console.ReadLine();
switch (played)
{

    case "Playing":
       
        player.Play();
        player.Pause();
        player.Stop();
        break;

    case "Recording":


        
        player.Record();
        player.Pause();
        player.Stop();
        break;
    default:
        Console.WriteLine("Неправильний запис");
        return;
}

Console.ReadLine();