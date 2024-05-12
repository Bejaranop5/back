namespace masconsulta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegimesController(MasconsultaContext context) : ControllerBase
    {
        private readonly MasconsultaContext _context = context;

        // GET: api/Regimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Regime>>> GetRegimes()
        {
            return await _context.Regimes.ToListAsync();
        }

        // GET: api/Regimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Regime>> GetRegime(int id)
        {
            var regime = await _context.Regimes.FindAsync(id);

            if (regime == null)
            {
                return NotFound();
            }

            return regime;
        }

        // PUT: api/Regimes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegime(int id, Regime regime)
        {
            if (id != regime.RegimeId)
            {
                return BadRequest();
            }

            _context.Entry(regime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegimeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Regimes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Regime>> PostRegime(Regime regime)
        {
            _context.Regimes.Add(regime);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RegimeExists(regime.RegimeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRegime", new { id = regime.RegimeId }, regime);
        }

        // DELETE: api/Regimes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegime(int id)
        {
            var regime = await _context.Regimes.FindAsync(id);
            if (regime == null)
            {
                return NotFound();
            }

            _context.Regimes.Remove(regime);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegimeExists(int id)
        {
            return _context.Regimes.Any(e => e.RegimeId == id);
        }
    }
}