using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_1.modelos;
using Proyecto_1.Server.Data;
 


namespace Proyecto_1.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {

            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Admin>>> GetAdmin()
        {
            var lista = await _context.Admin.ToListAsync();
            return Ok(lista);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<Admin>>> GetSingleAdmin(int id)
        {
            var miobjeto = await _context.Admins.FirstOrDefaultAsync(ob => ob.Id == id);
            if (miobjeto == null)
            {
                return NotFound(" :/");
            }

            return Ok(miobjeto);
        }
        [HttpPost]

        public async Task<ActionResult<Admin>> CreateAdmin(Admin objeto)
        {

            _context.Admins.Add(objeto);
            await _context.SaveChangesAsync();
            return Ok(await GetDbAdmin());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Admin>>> UpdateAdmin(Admin objeto)
        {

            var DbObjeto = await _context.Admins.FindAsync(objeto.Id);
            if (DbObjeto == null)
                return BadRequest("no se encuentra");
            DbObjeto.Nombre = objeto.Nombre;


            await _context.SaveChangesAsync();

            return Ok(await _context.Admins.ToListAsync());


        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Admin>>> DeleteAdmin(int id)
        {
            var DbObjeto = await _context.Admins.FirstOrDefaultAsync(Ob => Ob.Id == id);
            if (DbObjeto == null)
            {
                return NotFound("no existe :/");
            }

            _context.Admins.Remove(DbObjeto);
            await _context.SaveChangesAsync();

            return Ok(await GetDbAdmin());
        }


        private async Task<List<Admin>> GetDbAdmin()
        {
            return await _context.Admins.ToListAsync();
        }
   
    
    
    }



}
