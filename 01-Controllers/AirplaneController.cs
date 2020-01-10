using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Model;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly DBContext _context;

        public AirplaneController(DBContext context)
        {
            _context = context;
        }

        // GET: api/AirplaneModels
        [HttpGet]
        public IEnumerable<AirplaneModel> GetAirPlane()
        {
            using (var context = new DBContext())
            {
                return context.AirPlane.ToList();
            }
        }
 

        [HttpPost]
        public void   PostAirplane()
        {
            var context = new DBContext();
            AirplaneModel obj = new AirplaneModel();
            var airplane = new AirplaneModel { AIRModelo = "teste", AIRQtd = 5, AIRData = Convert.ToDateTime("01/01/2020") };
            context.AirPlane.Add(airplane);
            context.SaveChanges();
        }

        // DELETE: api/AirplaneModels/5
        [HttpDelete("{id}")]
        public string DeleteAirplane(int id)
        {
            try
            {
                var context = new DBContext();
                var airplaneModel = context.AirPlane.Find(id);
                context.AirPlane.Remove(airplaneModel);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                return "Error:" + e.ToString();
            }

            return null;

        }

        private bool AirplaneModelExists(int id)
        {
            return _context.AirPlane.Any(e => e.AIRCodigo == id);
        }
    }
}
