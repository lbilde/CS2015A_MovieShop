using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopDll.Contexts;
using MovieShopDll.Entities;

namespace MovieShopDll.Managers
{
    class GenreManager : IManager<Genre>
    {
        public Genre Create(Genre t)
        {
            using (var db = new MovieShopContext())
            {
                db.Genres.Add(t);
                db.SaveChanges();
                return t;
            }
        }

        public List<Genre> Read()
        {
            using (var db = new MovieShopContext())
            {
                return db.Genres.ToList();
            }
        }

        public Genre Read(int id)
        {
            using (var db = new MovieShopContext())
            {
                return db.Genres.FirstOrDefault(x => x.Id == id);
            }
        }

        public Genre Update(Genre t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
