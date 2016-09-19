using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopDll.Entities;
using MovieShopDll.Managers;

namespace MovieShopDll
{
    public class DllFacade
    {
        public IManager<Genre> GetGenreManager()
        {
         return new GenreManager();
        }
    }
}
