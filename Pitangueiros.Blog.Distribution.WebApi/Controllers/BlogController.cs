﻿using System.Collections.Generic;
using System.Web.Http;

namespace Pitangueiros.Blog.Distribution.WebApi.Controllers
{
    public class BlogController : ApiController
    {
        public BlogController() {
            
        }

        [HttpGet]
        public IList<string> GetValues() {
                return new List<string>() {
                    "Adroaldo",
                    "Astrogildo",
                    "Astronaldo",
                    "Abigail"
                };
        }
    }
}
