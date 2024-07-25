using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.SOLID.S.BadExample;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.State.BadExample
{
    public class Document
    {
        public DocumentStates State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public void Publish()
        {
            if (State == DocumentStates.DRAFT)
            {
                State = DocumentStates.MODERATION;
            }
            else if (State == DocumentStates.MODERATION)
            {
                if (CurrentUserRole == UserRoles.ADMIN)
                {
                    State = DocumentStates.PUBLISHED;
                }
            }
            else if (State == DocumentStates.PUBLISHED)
            {
                // do nothing
            }
        }
    }
}