using modul6_103022300066;

class Program
{
    static void Main(string[] args)
    {
        string[] videoTitles =
        {
            "Review film Captain Amerika",
            "Review film Ironman",
            "Review film BlackWidow",
            "Review film Thor",
            "Review film Hulk",
            "Review film Spiderman",
            "Review film Black Panther",
            "Review film Doctor Strange",
            "Review film Antman",
            "Review film WandaVision",
            "Review film Falcon and Winter Soldier",
            "Review film Loki",
            "Review film Hawkeye"
        };

        SayaTubeUser user = new SayaTubeUser("Avriela");
        foreach (string title in videoTitles)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
    }
}