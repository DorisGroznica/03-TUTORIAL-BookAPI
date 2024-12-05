﻿using BookAPI.Data;
using BookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]

}
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public AuthorsService? AuthorsService { get; set; }
    static AuthorsController(AuthorsService authorsService)
        {
            AuthorsService = authorsService;
    }
    [HttpPost]
    public IActionResult AddAuthor([FromBody] AuthorVM author)
    {
        AuthorsService.AddAuthor(author);
        return Ok();
    }
    [HttpGet("id")]
    public IActionResult GetAuthor([FromQuery] int id)
    {
        var author = AuthorsService.GetAuthorWithBooks(id);
        return Ok(author);
    }

    }