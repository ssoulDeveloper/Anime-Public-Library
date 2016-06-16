using System.Collections.Generic;


namespace AnimePublicLibrary.core
{
    public interface ISerie<TItem> : IList<TItem> where TItem : Item
    {
        string Title
        {
            get;
        }
    }
}
