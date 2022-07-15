using Microsoft.AspNetCore.Mvc;
using Model.OutModel;
using Models;
using Service;

namespace TicketTracingSystem.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class TicketTrackingController : ControllerBase
{
    private readonly ITicket _iTicket;

    public TicketTrackingController(ITicket iTicket)
    {
        _iTicket = iTicket;
    }
    
    [HttpPost]
    public APIExecutionResultModel Create([FromBody]Ticket ticket)
    {
        try
        {
            APIExecutionResultModel result = _iTicket.Create(ticket);
            
            return result;
        }
        catch (Exception e)
        {
            return new APIExecutionResultModel {returnCode = 404, returnMsg = e.Message};
        }
    }
}