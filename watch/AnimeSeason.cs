using System;
using AnimePublicLibrary.core;

namespace AnimePublicLibrary.watch
{
    public class AnimeSeason : Serie<Episode>, Item
    {
        private uint i;
        private OrderType type;

        public AnimeSeason(string title, uint number) : this(title, number, OrderType.InSerie) { }

        public AnimeSeason(string title, uint number, OrderType type) : base(title) {
            i = number;
        }

        public uint Index
        {
            get
            {
                return i;
            }
        }

        public OrderType Type{
            get
            {
                return type;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} (Season {1})", Title, Index);
        }
    }
}