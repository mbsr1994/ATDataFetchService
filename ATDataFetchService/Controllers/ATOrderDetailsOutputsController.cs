using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ATDataFetchService.DBContexts;
using ATDataFetchService.Models;



namespace ATDataFetchService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ATOrderDetailsOutputsController : ControllerBase
    {
        private readonly ATDBContext _context;



        public ATOrderDetailsOutputsController(ATDBContext context)
        {
            _context = context;
        }



        //// GET: api/ATOrderDetailsOutputs
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<ATOrderDetailsOutput>>> GetATOrderDetailsOutput()
        //{
        //    return await _context.ATOrderDetailsOutput.ToListAsync();
        //}



        //GET: api/ATOrderDetailsOutputs/5
        [HttpGet("{firm}")]
        public JsonResult GetATTopRoutesForAFirm(string firm = null)
        {
            string StoredProc = "exec usp_GetTopRoutesForAFirm " +
            "@firm = '" + firm + "'";
            if (firm != null)
            {
                try
                {
                    //return await _context.output.ToListAsync();
                    var a = _context.ATRouteOrderPercentage.FromSqlRaw(StoredProc).ToList();
                    //var asa=_context.Set<JsonResult>().FromSqlRaw(StoredProc).ToListAsync();
                    return new JsonResult(a);
                }
                catch (Exception ex)
                {



                }
            }
            return new JsonResult("");
        }

        [HttpGet("firm")]
        public JsonResult GetATTopCustomersForAFirm(string firmName)
        {
            string StoredProc = "exec usp_GetTopCustomersForAFirm " +
            "@firm = '" + firmName + "'";
                try
                {
                    //return await _context.output.ToListAsync();
                    var a = _context.ATCustomerOrderPercentage.FromSqlRaw(StoredProc).ToList();
                    //var asa=_context.Set<JsonResult>().FromSqlRaw(StoredProc).ToListAsync();
                    return new JsonResult(a);
                }
                catch (Exception ex)
                {



                }
            return new JsonResult("");
        }



        //// PUT: api/ATOrderDetailsOutputs/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutATOrderDetailsOutput(string id, ATOrderDetailsOutput aTOrderDetailsOutput)
        //{
        //    if (id != aTOrderDetailsOutput.client)
        //    {
        //        return BadRequest();
        //    }



        //    _context.Entry(aTOrderDetailsOutput).State = EntityState.Modified;



        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ATOrderDetailsOutputExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }



        //    return NoContent();
        //}



        // POST: api/ATOrderDetailsOutputs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpGet]
        public JsonResult PostATOrderDetailsOutput(string input = null)
        {
            string StoredProc = "exec usp_GetATTradeDataForDashboard " +
            "@firm = '" + input + "'";
            try
            {
                //return await _context.output.ToListAsync();
                var a = _context.ATOrderDetailsOutput.FromSqlRaw(StoredProc).ToList();
                //var asa=_context.Set<JsonResult>().FromSqlRaw(StoredProc).ToListAsync();
                return new JsonResult(a);
            }
            catch (Exception ex)
            {



            }
            return new JsonResult("");
        }

        [HttpPost]
        public JsonResult ATTopRoutes(string input = null)
        {
            string StoredProc = "exec usp_GetATTradeDataForDashboard " +
            "@firm = '" + input + "'";
            try
            {
                //return await _context.output.ToListAsync();
                var a = _context.ATOrderDetailsOutput.FromSqlRaw(StoredProc).ToList();
                //var asa=_context.Set<JsonResult>().FromSqlRaw(StoredProc).ToListAsync();
                return new JsonResult(a);
            }
            catch (Exception ex)
            {



            }
            return new JsonResult("");
        }



        // DELETE: api/ATOrderDetailsOutputs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteATOrderDetailsOutput(string id)
        //{
        //    var aTOrderDetailsOutput = await _context.ATOrderDetailsOutput.FindAsync(id);
        //    if (aTOrderDetailsOutput == null)
        //    {
        //        return NotFound();
        //    }



        //    _context.ATOrderDetailsOutput.Remove(aTOrderDetailsOutput);
        //    await _context.SaveChangesAsync();



        //    return NoContent();
        //}



        private bool ATOrderDetailsOutputExists(string id)
        {
            return true;
        }
    }
}