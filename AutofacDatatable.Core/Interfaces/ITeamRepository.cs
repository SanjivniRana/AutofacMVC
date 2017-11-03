using AutofacDatatable.Core.Model;
using System;
namespace AutofacDatatable.Core.Interfaces
{
    public interface ITeamRepository : IRepository
    {
        System.Collections.Generic.List<User> GetUsersInTeam(int teamId);
    }
}
