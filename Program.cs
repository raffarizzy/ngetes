using modul14_103022330138;

class Program
{
    static void Main()
    {
        // Kode berikut digunakan untuk menguji validasi Debug.Assert
        // Uncomment satu per satu untuk melihat hasil validasi saat development/testing
        // SayaTubeVideo videoInvalid = new SayaTubeVideo("");
        // SayaTubeVideo videoInvalid1 = new SayaTubeVideo("Lorem ipsum dolor sit amet...");
        // video.IncreasePlayCount(10000001);
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Raffa Rizky Febryan");

        // Tambah play count sebanyak 1000x (hampir mencapai batas maksimum int)
        for (int i = 0; i < 1000; i++)
        {
            video.IncreasePlayCount(2147484);
        }

        video.PrintVideoDetails();
    }
}
