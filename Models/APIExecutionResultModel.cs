namespace Model.OutModel
{
    public class APIExecutionResultModel : ExecutionResult
    {
        public object data;
    }
    
    public class ExecutionResult
    {
        public int returnCode;

        public string returnMsg;
    }
}