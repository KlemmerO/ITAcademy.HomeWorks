using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Song
{
    class Program
    {
        static void Main(string[] args)
        {
            var getSongData = new GetSongData
            {
                Name = "Lyric",
                Lenght = 1,
                Author = "ABBA",
                Date = 1980
            };
            string jsonData = JsonConvert.SerializeObject(GetSongData);
            Console.WriteLine(GetSongData);
        }
    }
}
