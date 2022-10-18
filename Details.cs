using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOffice
{
    public class Details
    {
        public int DetailsID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string email { get; set; }
        public int telephone { get; set; }

        public virtual ICollection<Client> Clients { get; private set; } = new ObservableCollection<Client>();
    }
}
