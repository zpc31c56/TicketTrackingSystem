using Model.OutModel;
using Models;

namespace Service;

public interface ITicket
{
    APIExecutionResultModel Create(Ticket ticket);
    //APIExecutionResultModel Update(IEnumerable<Guid> ids);
    // APIExecutionResultModel Delete(Ticket ticket);
    // APIExecutionResultModel Get(Ticket ticket);
}