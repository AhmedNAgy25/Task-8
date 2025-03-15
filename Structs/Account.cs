
namespace Task8.Structs
{
    public struct Account
    {
        public int AccountId { get; }
        public string AccountHolder { get; }
        public decimal Balance { get; }

        public Account(int id, string holder, decimal balance)
        {
            AccountId = id;
            AccountHolder = holder;
            Balance = balance;
        }
    }
}
