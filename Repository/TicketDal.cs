using CommonUitility;
using Models;

namespace Repository;

public class TicketDal : ITicketDal
{
    public int CreateTicket(Ticket ticket)
    {
        string cmdTxt = @"INSERT INTO ""Ticket"" (
                                    ""IssueId""
                                    ,""Issue""
                                    ,""Status""
                                    ,""Asignee""
                                    ,""Reporter""
                                    ,""Priority""
                                    ,""IssueType""
                                    ,""CreateOn""
                                    )
                                VALUES (
                                    @IssueId
                                    ,@Issue
                                    ,@Status
                                    ,@Asignee
                                    ,@Reporter
                                    ,@Priority
                                    ,@IssueType
                                    ,@CreateOn
                                    )";
        
        return DapperUitility.ExecuteNonQuery<Ticket>(cmdTxt, ticket);
    }
}