using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBox.Entity
{
    interface Interface1
    {
        int Id { get; set; }
    }

    public partial class Authors : Interface1
    { 
    }

    public partial class Compositions : Interface1
    { 
    }

    public static class Repo<TEntity>
        where TEntity : Interface1
    {
        public static void Delete(DbSet<TEntity> db, int id)
        {
            var entity = db.FirstOrDefault(e => e.Id == id);
            db.Remove(entity);
        }

        static void Run()
        {
            Repo<Authors>.Delete(null, 12);
            Repo<Compositions>.Delete(null, 13);
        }

    }
}
