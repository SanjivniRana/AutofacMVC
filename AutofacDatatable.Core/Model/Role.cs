using System.Collections.Generic;

namespace AutofacDatatable.Core.Model
{
    public class Role : BaseModel<int>
    {
        public virtual IEnumerable<User> Users { get; set; }
    }
}
