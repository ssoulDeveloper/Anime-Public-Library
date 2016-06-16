
using System.Collections.Generic;

namespace AnimePublicLibrary.core
{
    public class Serie<TItem> : List<TItem>, ISerie<TItem> where TItem : Item
    {
        private string title;

        public Serie(string title) : base()
        {
            this.title = title;
        }

        public string Title
        {
            get
            {
                return title;
            }
        }
    }
}
