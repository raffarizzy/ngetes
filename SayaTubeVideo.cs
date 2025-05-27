using System;
using System.Diagnostics;

namespace modul14_103022330138
{
    class SayaTubeVideo
    {
        private static readonly Random _rand = new Random();
        private int _id;
        private string _title;
        private int _playCount;

        // Konstruktor untuk inisialisasi video
        public SayaTubeVideo(string title)
        {
            Debug.Assert(!string.IsNullOrEmpty(title), "Title tidak boleh kosong!");
            Debug.Assert(title.Length <= 100, "Title maksimal 100 karakter!");

            _id = _rand.Next(10000, 99999);
            _title = title;
            _playCount = 0;
        }

        // Menambahkan jumlah view (maksimal 10 juta)
        public void IncreasePlayCount(int views)
        {
            Debug.Assert(views <= 10000000, "Penambahan play count maksimal 10.000.000");

            try
            {
                checked
                {
                    _playCount += views;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi error overflow saat menambahkan play count!");
            }
        }

        // Menampilkan detail video
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID         : " + _id);
            Console.WriteLine("Title      : " + _title);
            Console.WriteLine("Play Count : " + _playCount);
        }
    }
}
