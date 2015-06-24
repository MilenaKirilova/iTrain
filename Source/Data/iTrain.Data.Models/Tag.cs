namespace iTrain.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using iTrain.Data.Common.Models;
    using System.ComponentModel.DataAnnotations.Schema;

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
