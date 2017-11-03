using System.Collections.Generic;

namespace AutofacDatatable.Core.Model
{
    public class Team : BaseModel<int>
    {
        public virtual IEnumerable<User> Users { get; set; }
    }
}
