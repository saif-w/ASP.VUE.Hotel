using Hotel.App.Data.Entity;
using Hotel.Repositorys.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherTypeController : ControllerBase
    {
        private readonly IOtherTypeRepostry _context;
        public OtherTypeController(IOtherTypeRepostry context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetFullData()
        {
            return Ok(await _context.GetFullAsync());
        }
        [HttpGet]
        [Route("GetIID/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _context.GetAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] OtherType otherType)
        {
            try
            {
                var data = await _context.AddAsync(otherType);

                return Ok("تم الاضافة بانجاح");
            }
            catch (Exception ex)
            {

                return BadRequest("يوجد خطاء");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] OtherType otherType)
        {
            try
            {
                await _context.UpdateAsync(otherType);

                return Ok("تم التعديل");
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("Delete/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _context.DeleteAsync(Id);
            return Ok("تم الحذف");
        }
    }
}
