using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300066
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username { get; private set; }
        public SayaTubeUser(string username)
        {
            Random random = new Random();
            this.id = random.Next(12345, 67890);
            this.Username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if(video != null)
            {
                uploadedVideos.Add(video);
            }
        }

        public int GetTotalVideos()
        {
            return uploadedVideos.Count;
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i + 1}: {uploadedVideos[i].GetPlayCount()}");
            }
        }
    }
}
