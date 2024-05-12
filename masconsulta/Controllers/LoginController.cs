namespace masconsulta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(MasconsultaContext context) : ControllerBase
    {
        private readonly MasconsultaContext _context = context;

        [HttpPost()]
        public async Task<ActionResult<User>> Login(LoginRequest loginRequest)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == loginRequest.Email && x.Password == loginRequest.Password && x.IsActive == true);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
    }
}