using AnimePublicLibrary.core.items;
using System;

namespace AnimePublicLibrary.watch
{
    public class Episode : ItemWithType<EpsType>
    {
        private DateTime date;

        public Episode(string title, uint number) : this(title, number, EpsType.Normal) { }

        public Episode(string title, uint number, EpsType type) : base(title, number, type){
            date = DateTime.MinValue;
        }

        /// <summary>
        /// Create new Normal episode with specified title, number and date when it was (or will be) aired.
        /// </summary>
        /// <param name="title"> episode title</param>
        /// <param name="number"> episode number</param>
        /// <param name="airdate"> date when it was (or will be) aired</param>
        public Episode(string title, uint number, DateTime airdate) : base(title, number, EpsType.Normal)
        {
            date = airdate;
        }

        public sealed override string Number
        {
            get
            {
                switch (Type)
                {
                    case EpsType.Short:
                    case EpsType.Film:
                        return Type.ToString();
                    case EpsType.OAV:
                    case EpsType.OVA:
                    case EpsType.Special:
                        return "Episode " + base.Number + ".5";
                    case EpsType.Normal:
                    default:
                        return "Episode " + base.Number;
                        
                }
            }
        }

        /// <summary>
        /// Date when this episode was (or will be) aired.
        /// </summary>
        public DateTime AirDate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
    }

    public enum EpsType
    {
        Normal,
        Short,
        OVA,
        OAV, 
        Film,
        Special
    }
}