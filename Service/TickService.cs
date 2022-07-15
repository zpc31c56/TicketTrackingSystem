using Model.OutModel;
using Models;
using Repository;

namespace Service;

public class TickService : ITicket
{
    private readonly ITicketDal _iticketDal;
    
    public TickService(ITicketDal iticketDal)
    {
        _iticketDal = iticketDal;
    }
    public APIExecutionResultModel Create(Ticket ticket)
    {
        try
        {
            APIExecutionResultModel resultModel = new APIExecutionResultModel();
            var result = _iticketDal.CreateTicket(ticket);
            resultModel.returnMsg = result > 0 ? "新增成功" : "無資料";
            
            return new APIExecutionResultModel {returnCode = 200};
        }
        catch (Exception e)
        {
            return new APIExecutionResultModel {returnCode = 404, returnMsg = e.Message};
        }
    }
    
}