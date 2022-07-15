using Models;

namespace Repository;

public interface ITicketDal
{
    int CreateTicket(Ticket ticket);
    //int Update(IEnumerable<Guid> ids);
}