using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_Stars.Data
{
    public class Candy

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CName { get; set; }
        public string Ctype { get; set; }
        public int CPrice { get; set; }
        public int Csize { get; set; }

        //foreign key connects Orders table
        public int OID { get; set; }
        [ForeignKey("OID")]
        public int Orders { get; set; }
        //foreign key connects to the candy store table

        public int CandyStoreID { get; set; }
        [ForeignKey("CandyStoreID")]
        public int CID { get; set; }
    }
}
