namespace Sufler.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("project")]
    public partial class project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public project()
        {
            participants = new HashSet<participant>();
            responses = new HashSet<response>();
        }

        [Key]
        public Guid project_id { get; set; }

        [Required]
        [StringLength(150)]
        public string project_name { get; set; }

        public Guid creator { get; set; }

        [Required]
        [StringLength(2000)]
        public string description { get; set; }

        public int price { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime date_created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime date_end { get; set; }

        public int? tags { get; set; }

        [Column("checked")]
        public bool? _checked { get; set; }

        public bool? compleated { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participant> participants { get; set; }

        public virtual user user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<response> responses { get; set; }

        public virtual tag tag { get; set; }
    }
}
