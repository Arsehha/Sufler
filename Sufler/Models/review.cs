namespace Sufler.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("review")]
    public partial class review
    {
        [Key]
        public int review_id { get; set; }

        public Guid? reviewer { get; set; }

        public Guid recepient { get; set; }

        [Required]
        [StringLength(20)]
        public string type { get; set; }

        public int rate { get; set; }

        [StringLength(2000)]
        public string text { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime date_created { get; set; }

        public virtual user user { get; set; }

        public virtual user user1 { get; set; }
    }
}
