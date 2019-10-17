using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_Stars.Data
{
    public class Candy_Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CName { get; set; }
        public string Ctype { get; set; }
        public int CPrice { get; set; }
        public int Csize { get; set; }

        
        
    }
}
