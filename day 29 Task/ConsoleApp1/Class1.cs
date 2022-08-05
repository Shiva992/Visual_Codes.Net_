[System.Serializable]
public class Exception : System.Exception
{
    private static readonly string DefaultMessage = "Account balance is insufficient for the transaction.";

    public string AccountName { get; set; }
    public int AccountBalance { get; set; }
    public int TransactionAmount { get; set; }

    public Exception() : base(DefaultMessage) { }
    public Exception(string message) : base(message) { }
    public Exception(string message, System.Exception innerException)
    : base(message, innerException) { }

    public Exception(string accountName, int accountBalance, int transactionAmount)
    : base(DefaultMessage)
    {
        AccountName = accountName;
        AccountBalance = accountBalance;
        TransactionAmount = transactionAmount;
    }

    //public Exception(string accountName, int accountBalance, int transactionAmount, System.Exception innerException)
    //: base(DefaultMessage, innerException)
    //{
    //    AccountName = accountName;
    //    AccountBalance = accountBalance;
    //    TransactionAmount = transactionAmount;
    //}

    protected Exception(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

}