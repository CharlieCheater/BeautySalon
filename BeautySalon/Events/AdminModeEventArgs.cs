using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Events
{
    public class AdminModeEventArgs : EventArgs
    {
        public bool IsAdmin { get; set; }
    }
}
