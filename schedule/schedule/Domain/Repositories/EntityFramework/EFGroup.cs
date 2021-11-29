using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using schedule.Domain.Entities;
using schedule.Domain.Repositories.Abstract;

namespace schedule.Domain.Repositories.EntityFramework
{
    public class EFGroup : IGroupRepository
    {
        private readonly AppBDContext context;
        public EFGroup(AppBDContext context)
        {
            this.context = context;
        }
        public void DeleteGroup(Guid id)
        {
            context.Group.Remove(new Group() { Id = id });
            context.SaveChanges();
        }

        public Group GetGroupById(Guid id)
        {
            return context.Group.FirstOrDefault(x => x.Id == id);
        }

        public Group GetGroupByNumGroup(string numGroup)
        {
            return context.Group.FirstOrDefault(x => x.numGroup == numGroup);
        }

        public IQueryable<Group> GetGroups()
        {
            return context.Group;
        }

        public void SaveGroup(Group entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
