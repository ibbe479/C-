using System;

namespace petInfo;

public class album
{
    private string albumName;
    private string artistName;
    private int numOfTracks;

    public void setInfo()
    {
        Console.WriteLine("Press enter to start the album function");
        Console.ReadLine();

        Console.WriteLine("what is the album name? ");
        albumName = Console.ReadLine();

        Console.WriteLine("who is the artist? ");
        artistName = Console.ReadLine();

        Console.WriteLine("how many tracks are in the album? ");
        numOfTracks = int.Parse(Console.ReadLine());

    }

    public void showInfo(){
         Console.WriteLine($"Album name: {albumName} ");
         Console.WriteLine($"Artist name: {artistName}")
         Console.WriteLine($"Number of tracks: {numOfTracks}")

    }
    
}
