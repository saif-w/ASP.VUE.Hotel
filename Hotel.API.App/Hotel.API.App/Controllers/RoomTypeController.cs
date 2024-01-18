using Hotel.App.Data.Entity;
using Hotel.Repositorys.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        public RoomTypeController(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        [HttpGet]
        public  async Task<IActionResult> GetFullData() 
        {
           return Ok(await _roomTypeRepository.GetFullAsync());
        }
        [HttpGet]
        [Route("GetIID/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _roomTypeRepository.GetAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] RoomType roomType)
        {
            try
            {
                var data = await _roomTypeRepository.AddAsync(roomType);

                return Ok("تم الاضافة بانجاح");
            }
            catch (Exception ex)
            {

                return BadRequest("يوجد خطاء");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] RoomType roomType)
        {
            try
            {
                await _roomTypeRepository.UpdateAsync(roomType);

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
            await _roomTypeRepository.DeleteAsync(Id);
            return Ok("تم الحذف");
        }
    }
}
