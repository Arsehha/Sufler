namespace Sufler.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("response")]
    public partial class response
    {
        [Key]
        public int response_id { get; set; }

        public Guid id_project { get; set; }

        public Guid id_user { get; set; }

        [StringLength(2000)]
        public string message { get; set; }

        public virtual project project { get; set; }

        public virtual user user { get; set; }
    }
}
