using AnimePublicLibrary.core;
using AnimePublicLibrary.world;
using System;

namespace AnimePublicLibrary.watch
{
    public class AnimeSeason : Serie<Episode>, Item
    {
        private uint index;
        private OrderType type;
        private SeasonStatus status;

        private Publisher pub;

        public AnimeSeason(string title, uint number) : this(title, number, OrderType.InSerie) { }

        public AnimeSeason(string title, uint number, OrderType type) : base(title) {
            index = number;
            pub = null;
        }

        public uint Index
        {
            get
            {
                return index;
            }
        }

        public OrderType Type{
            get
            {
                return type;
            }
        }

        public DateTime AirStart
        {
            get
            {
                if (Count > 0) return this[0].AirDate;
                else return DateTime.MaxValue;
            }
        }

        public DateTime AirEnd
        {
            get
            {
                if (Status == SeasonStatus.Finished && Count > 0) return this[Count - 1].AirDate;
                else return DateTime.MaxValue;
            }
        }

        public SeasonStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public Publisher Publisher
        {
            get
            {
                return pub;
            }
            set
            {
                pub = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} (Season {1})", Title, Index);
        }
    }

    public enum SeasonStatus
    {
        NB,
        Planning,
        Airing,
        Finished
    }
}