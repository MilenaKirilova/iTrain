namespace iTrain.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using iTrain.Data.Common.Models;

    public class Tag: AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Index]
        public bool IsDeleted { get; set; }

        public System.DateTime? DeletedOn { get; set; }
    }
}
