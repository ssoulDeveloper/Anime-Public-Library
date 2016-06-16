
namespace AnimePublicLibrary.world.people
{
    public class Person
    {
        private string name;
        private string surname;

        private static FullnameComposer composer;
        
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
        }

        public string Fullname
        {
            get
            {
                if (composer != null)
                    return composer.Invoke(Name, Surname);
                else
                    return Name + " " + Surname;
            }
        }

        /// <summary>
        /// Set default composer for enviroment.
        /// </summary>
        /// <param name="composer"> composer to use for Fullname</param>
        public static void SetComposer(FullnameComposer composer)
        {
            Person.composer = composer;
        }
    }

    /// <summary>
    /// Compose a fullname based on specific arguments (ex. Name, Surname)
    /// </summary>
    /// <param name="args"> arguments defined by composer</param>
    /// <returns></returns>
    public delegate string FullnameComposer(params string[] args);
}
