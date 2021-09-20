using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesBeDelegating
{
    class Diplomacy
    {
        // 1 - Define a delegate
        // 2 - Define an event based on the delegate
        // 3 - Raise the event

        // This delegate's name is Bob.
        public delegate void PresidentialDecreeEventHandler(object source, EventArgs args);
        public event PresidentialDecreeEventHandler Decreed;

        public void SendPresidentialMessage(PresidentialAction action)
        {
            Console.WriteLine("The president has decreed that he has signed a treaty.");

            OnPresidentialDecree();
        }

        protected virtual void OnPresidentialDecree()
        {
            if (Decreed is not null)
                Decreed(this, EventArgs.Empty);
        }
    }
}
