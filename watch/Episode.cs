using AnimePublicLibrary.core;

namespace AnimePublicLibrary.watch
{
    public class Episode : ItemWithType<EpsType>
    {

        public Episode(string title, uint number) : base(title, number, EpsType.Normal) { }

        public Episode(string title, uint number, EpsType type) : base(title, number, type){ }

        public override string Number
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