namespace SpendingSolution.Common.Mediator
{
    using SpendingSolution.Common.Mediator.Contracts;

    public interface ICustomQueryReader
    {
        Task<TResult> Get<TQuery, TResult>(TQuery query)
            where TQuery : CustomQuery
            where TResult : class;
    }
}
