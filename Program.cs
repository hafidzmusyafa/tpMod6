using System;

class SayaTubeVideo
{
    int id;
    string title;
    int playCount;

    public SayaTubeVideo(string title)
    {
        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int x)
    {
        playCount += x;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID Video    : {id}");
        Console.WriteLine($"Judul Video : {title}");
        Console.WriteLine($"Play Count  : {playCount}\n");
    }
}

class main
{
    public static void Main(String[] args)
    {
        SayaTubeVideo tubeVideo = new SayaTubeVideo("Tutorial Design By Contract – [HAFIDZ MUSYAFA AZMI]");

        tubeVideo.PrintVideoDetails();
    }
}