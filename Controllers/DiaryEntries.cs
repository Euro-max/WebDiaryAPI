using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryEntries : ControllerBase
    {

            // GET: api/<WebAPI>

            public class DiaryEntriesController : ControllerBase
            {
                private readonly ApplicationDbContext _context;
                public DiaryEntriesController(ApplicationDbContext context)
                {
                    _context = context;
                }
                [HttpGet]

                public IEnumerable<AP> GetDiaryEntries()
                {
                    return _context.DiaryEntries.ToList();
                }


            }
        }
    }



