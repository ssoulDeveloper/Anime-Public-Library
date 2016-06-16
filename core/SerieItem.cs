namespace AnimePublicLibrary.core
{
    public class SerieItem : Item
    {
        private string title;
        private uint num;

        public SerieItem(string title, uint number)
        {
            this.title = title;
            num = number;
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public uint Index
        {
            get
            {
                return num;
            }
        }

        public virtual string Number
        {
            get
            {
                return Index.ToString();
            }
        }

    }
}