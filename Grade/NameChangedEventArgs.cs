﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class NameChangedEventArgs : EventArgs
    {
        public string existingName { get; set; }
        public string newName { get; set; }

        // members are used for abstraction 
        // events for notification 
        // field and properties for state


    }
}
