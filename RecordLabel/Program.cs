using RecordLabel;

Console.WriteLine("Welcome to the Record Label!");
Console.WriteLine();
Console.WriteLine("We need someone to help us log all of our records.\nFollow the prompts below to create albums for our inventory.");
Console.WriteLine();
Console.Write("Enter 'quit' to exit the program. Or, Enter an album title: ");

var inventory = new Inventory();
string title = Console.ReadLine();

while (title != "quit")
{
    Console.Write("Enter the album artist: ");
    var artist = Console.ReadLine();
    var album = new Album(artist, title);
    inventory.AddAlbum(album);

    Console.WriteLine("Enter album songs, with a comma between each song. An album can have up to 10 songs.  For example: The Song That Never Ends, Happy Birthday, Thriller, Take Me to the River");
    Console.Write(": ");
    var songInput = Console.ReadLine();

    var songTitles = songInput.Split(',');

    for (var i = 0; i < songTitles.Length && i < 10; i++)
    {
        album.AddSong(songTitles[i]);
    }

    Console.WriteLine($"** {album.Title} **");
    Console.WriteLine("Side A");
    foreach (var song in album.SideASongs)
    {
        Console.WriteLine($" * {song.TrimStart()}");
    }
    Console.WriteLine("Side B");
    foreach (var song in album.SideBSongs)
    {
        Console.WriteLine($" * {song.TrimStart()}");
    }

    Console.Write("Enter 'quit' to exit the program. Or, Enter another album title: ");
    title = Console.ReadLine();
}

Console.WriteLine($"Thank you for creating {inventory.AllSongs().Count} records for the label!");



