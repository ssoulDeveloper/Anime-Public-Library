using AnimePublicLibrary.world.people;

namespace AnimePublicLibrary.world
{
    public class StaffMember : Person
    {
        private StaffRole role;

        public StaffMember(string name, string surname, StaffRole role) : base(name, surname)
        {
            this.role = role;
        }

        public StaffRole Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }


    }

    public enum StaffRole
    {
        //TODO fill some roles
    }
}
