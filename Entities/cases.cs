using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QC_EntityFramework.Entities
{
    public class cases
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long caseid { get; set; }
        public string name { get; set; }
        public string memo { get; set; }
        public string owner { get; set; }
        public string date { get; set; }
    }
}
