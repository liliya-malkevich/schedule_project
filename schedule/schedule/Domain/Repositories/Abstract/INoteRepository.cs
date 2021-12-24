using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories.Abstract
{
    interface INoteRepository
    {
        IQueryable<Note> GetNote();
        Note GetNoteById(Guid id);
        Note GetNoteByName(String nameNote);
        void SaveNote(Note entity);
        void DeleteNote(Guid id);
    }
}
