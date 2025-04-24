namespace Sufler.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("participant")]
    public partial class participant
    {
        [Key]
        public int participant_id { get; set; }

        public Guid id_project { get; set; }

        public Guid id_user { get; set; }

        public virtual project project { get; set; }

        public virtual user user { get; set; }
    }
}
