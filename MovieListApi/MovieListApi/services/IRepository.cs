using MovieListApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListApi.services
{
    public interface IRepository
    {
        List<Genre> GetAllGenres();
    }
}
