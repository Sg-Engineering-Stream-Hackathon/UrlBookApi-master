﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelService;

namespace WebApiCatalog.Controllers.Api.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BookMarkController : ControllerBase
    {
        private readonly IBookmarkCardService _bookmarkCardSvc;
        public BookMarkController(IBookmarkCardService bookmarkCardSvc)
        {
            _bookmarkCardSvc = bookmarkCardSvc;

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddBookMark([FromBody] BookmarkCard model)
        {
            bool result = await _bookmarkCardSvc.CreateBookMarkCard(model);

            if (result)
            {
                return Ok(new { Message = "Card Successfully!" });
            }

            return BadRequest(new { Message = "Issue in Saving the card." });
        }
    }
}
