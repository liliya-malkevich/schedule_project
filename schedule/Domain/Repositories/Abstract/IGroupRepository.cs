using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories.Abstract
{
   public interface IGroupRepository
    {
        IQueryable<Group> GetGroups();
        Group GetGroupById(Guid id);
        Group GetGroupByNumGroup(String numGroup);
        void SaveGroup(Group entity);
        void DeleteGroup(Guid id);
    }
}
