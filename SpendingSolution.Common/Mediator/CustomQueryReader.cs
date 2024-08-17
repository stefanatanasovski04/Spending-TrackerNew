namespace SpendingSolution.Common.Mediator
{
    using SpendingSolution.Common.Mediator.Contracts;

    public class CustomQueryReader : ICustomQueryReader
    {
        private readonly CustomMediator mediator;

        public CustomQueryReader(CustomMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<TResult> Get<TQuery, TResult>(TQuery query)
            where TQuery : CustomQuery
            where TResult : class
        {
            return await mediator.Send<TQuery, TResult>(query);
        }
    }
}
