using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWindow.Model
{
    internal class LongTermKeepContract : Contract
    {
        public string option { get; set; }

        public string type { get; set; }
        
        public float period { get; set; }

        
    }
}
