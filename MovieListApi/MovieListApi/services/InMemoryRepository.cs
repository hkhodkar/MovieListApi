using MovieListApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListApi.services
{
    public class InMemoryRepository : IRepository
    {
        private List<Genre> _genres;

        public InMemoryRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre(){Id=1 , Name = "Comedy"},
                new Genre(){Id=2 , Name = "Action"}
            };
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }
    }
}
