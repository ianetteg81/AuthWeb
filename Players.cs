using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthPractice.Data
{
    public class Players
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        //foreign key connects Teams table
        public int TID { get; set; }
        [ForeignKey("TID")]
        public Team Teams { get; set; }

        //foreign  key connects Coach table
        public int CID { get; set; }
        [ForeignKey("CID")]
        public Coach Coaches { get; set; }


    }
    
}
