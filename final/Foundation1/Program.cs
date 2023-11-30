class Program
{
    static void Main()
    {

        Video video1 = new Video("Paramore - The News (Official Video)", "Paramore", "3:08");
        video1.AddComment("@lifenoggin", "My body and brain are not ready for what this album will do to me.");
        video1.AddComment("@PrincessZ1", "Why is this band so perfect? Perfect singer. Perfect guitarist. Perfect drummer. Perfect bassist.");

        Video video2 = new Video("PVRIS - I DON'T WANNA DO THIS ANYMORE (OFFICIAL MUSIC VIDEO)", "PVRIS", "3:28");
        video2.AddComment("@Yan_Filipe", "I discovered PVRIS just a couple months ago but I gotta admit that I have never been so hyped for an album as I am now, that's for sure");
        video2.AddComment("@_jivasu", "The visuals in this era are immaculate. (Also, farmer Lynn = best Lynn). ❤");

        Video video3 = new Video("All Time Low: Sleepwalking [OFFICIAL VIDEO]", "All Time Low", "3:15");
        video3.AddComment("@geminidragon4898", "It’s insane to think they’ve been singing for 20 years and they’re still so good I love their songs");
        video3.AddComment("@SalveASMR", "10 years of listening to you guys and you still able to make a grown man cry.");



        // CREATE THE VIDEO LIST.
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        //SHOWS THE VIDEO INFORMATION.
        foreach (Video video in videoList)
        {
            video.ShowVideoInfo();
        }
    }
}






