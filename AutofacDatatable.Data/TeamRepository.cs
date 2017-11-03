using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutofacDatatable.Core.Interfaces;
using AutofacDatatable.Core.Model;

namespace AutofacDatatable.Data
{
    public class TeamRepository : SqlRepository, ITeamRepository
    {
        public TeamRepository(IDbContext context)
            : base(context)
        {

        }
        public List<User> GetUsersInTeam(int teamId)
        {
            return (from u in this.GetAll<User>()
                    where u.TeamId == teamId
                    select u).ToList();
        }
    }
}
