using Microsoft.AspNetCore.Mvc;
using MovieListApi.Entities;
using MovieListApi.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListApi.Controllers
{
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IRepository _repository;
        public GenreController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public List<Genre> GetAllGenres()
        {
            return _repository.GetAllGenres();
        }

    }
}
