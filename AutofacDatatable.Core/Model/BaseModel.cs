using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutofacDatatable.Core.Model
{
    public abstract class BaseModel<T>
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }

        [Required, StringLength(maximumLength: 250)]
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual bool IsPersonMarried { get; set; }
        public virtual string State { get; set; }
        public virtual string City { get; set; }
        
    }
}