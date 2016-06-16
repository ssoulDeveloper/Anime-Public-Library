using AnimePublicLibrary.core;

namespace AnimePublicLibrary.play
{
    public class Game : SerieItem
    {
        private string[] platforms;

        public Game(string title, params string[] platforms) : this(title, 1, platforms) { }

        public Game(string title, uint number, params string[] platforms) : base(title, number)
        {
            this.platforms = platforms;
        }

        public string[] SupportedPlatforms
        {
            get
            {
                return platforms;
            }
        }


    }

}
