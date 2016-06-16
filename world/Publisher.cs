using AnimePublicLibrary.world.people;
using System.Collections.Generic;

namespace AnimePublicLibrary.world
{
    public class Publisher : Organization
    {
        private List<StaffMember> members;

        public Publisher(string name) : base(name)
        {
            members = new List<StaffMember>();
        }

        public StaffMember this[int index]
        {
            get
            {
                return members[index];
            }
        }

        public void AddMember(StaffMember member)
        {
            members.Add(member);
        }

        public void AddMultiple(IEnumerable<StaffMember> members) 
        {
            this.members.AddRange(members);
        }
    }
}
