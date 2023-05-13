using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class BillFix
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(50)]
        public string status { get; set; }

        public DateTime? dateCreate { get; set; }

        public BillFix()
        {
            this.Accessories = new HashSet<Accessory>();
        }

        public int? fixWorkerID { get; set; }
        public FixWorker FixWorker { get; set; }

        public int? customerID { get; set; }
        public Customer Customer { get; set; }

        public virtual ICollection<Accessory> Accessories { get; set; }
    }
}
