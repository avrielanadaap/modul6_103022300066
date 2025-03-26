using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300066
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(12345, 67890);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 0)
            {
                playCount+= count;
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"User : {id}");

            int i = 1;
            foreach (var video in title)
            {
                Console.WriteLine($"Video {i}: {title} - {playCount}");
                i++;
            }
        }

        public int GetPlayCount()
        {
            return this.playCount;
        }

        public string GetTitle()
        {
            return this.title;
        }
    }
}
