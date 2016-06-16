
namespace AnimePublicLibrary.core
{
    public class ItemWithType<T> : SerieItem
    {
        private T type;

        public ItemWithType(string title, uint number, T type) : base(title, number)
        {
            this.type = type;
        }

        public T Type
        {
            get
            {
                return type;
            }
        }
    }
}
