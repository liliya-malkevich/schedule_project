using Domain;
using Domain.Entities;
using Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories.EntityFramework
{
    public class EFNote : INoteRepository
    {
        private readonly AppBDContext context;
        public EFNote(AppBDContext context)
        {
            this.context = context;
        }
        public void DeleteNote(Guid id)
        {
            context.Note.Remove(new Note() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<Note> GetNote()
        {
            return context.Note;
        }

        public Note GetNoteById(Guid id)
        {
            return context.Note.FirstOrDefault(x => x.Id == id);
        }

        public Note GetNoteByName(string nameNote)
        {
            return context.Note.FirstOrDefault(x => x.nameNote == nameNote);
        }

        public void SaveNote(Note entity)
        {
            if (entity.Id == default) context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
