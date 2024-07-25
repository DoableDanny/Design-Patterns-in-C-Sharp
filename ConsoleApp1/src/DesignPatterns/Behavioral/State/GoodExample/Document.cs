using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.State.GoodExample
{
    public class Document
    {
        public State State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles currentUserRole)
        {
            State = new DraftState(this); // New documents have draft state by default
            CurrentUserRole = currentUserRole;
        }

        public void Publish()
        {
            State.Publish();
        }
    }
}