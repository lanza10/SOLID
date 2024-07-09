using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Player : BasePlayer, IReferenced
    {
        public IPlayer ReferencePlayer { get; set; } = null;

        public virtual void AssignReferencePlayer(IPlayer newReference)
        {
            //Simulate tasks
            ReferencePlayer = newReference;
        }
    }
}
