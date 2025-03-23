using System;
using System.Diagnostics;

class SayaTubeVideo
{
    int id;
    string title;
    int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Judul video tidak boleh null dan maksimal 100 karakter.");

        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int x)
    {
        Debug.Assert(x <= 10000000, "Penambahan play count maksimal 10.000.000.");

        try
        {
            checked
            {
                this.playCount += x;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
        }
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

        // Menampilkan detail video awal
        tubeVideo.PrintVideoDetails();

        // Uji fungsi IncreasePlayCount dengan angka normal
        tubeVideo.IncreasePlayCount(1000);
        tubeVideo.PrintVideoDetails();

        // Uji overflow menggunakan for loop untuk mempercepat proses
        for (int i = 0; i < 100; i++)
        {
            tubeVideo.IncreasePlayCount(10000000); // Uji batas maksimal 10.000.000
        }

        tubeVideo.PrintVideoDetails();
    }
}