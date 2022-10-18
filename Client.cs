using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace MiniOffice
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }

        public int DetailsID { get; set; }
        public virtual Details Details { get; set; }
    }
}
