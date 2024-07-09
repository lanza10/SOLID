﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal interface IReferenced : IPlayer
    {
        IPlayer ReferencePlayer { get; set; }

        void AssignReferencePlayer(IPlayer newReference);
    }
}
