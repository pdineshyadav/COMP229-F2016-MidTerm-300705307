namespace COMP229_F2016_MidTerm_300705307.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TodoTable")]
    public partial class TodoTable
    {
        [Key]
        public int TodoID { get; set; }

        [StringLength(50)]
        public string TodoDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string TodoNotes { get; set; }

        public int Completed { get; set; }
    }
}
