using Business.MongoDbManager.IMongoManager;
using Contract.DTO;
using DAL.MongoDbService.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCore.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IMongoBManager _mongoManager;
        public SampleController(IMongoBManager mongoManager)
        {
            _mongoManager = mongoManager;
        }

        [HttpGet("GetAllSample")]
        public IActionResult GetAllSample()
        {
            try
            {
                IEnumerable<SampleDTO> lst = _mongoManager.Get();
                return Ok(new { result = "Success", data = lst });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetSampleById/{id}")]
        public IActionResult GetSampleById(string id)
        {
            try
            {
                SampleDTO model = _mongoManager.Get(id);
                return Ok(new { result = "Success", data = model });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateSample")]
        public IActionResult CreateSample(SampleDTO model)
        {
            try
            {
                _mongoManager.Create(model);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateSample")]
        public IActionResult UpdateSample(SampleDTO model)
        {
            try
            {
                _mongoManager.Update(model);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteSample/{id}")]
        public IActionResult DeleteSample(string id)
        {
            try
            {
                _mongoManager.Delete(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
