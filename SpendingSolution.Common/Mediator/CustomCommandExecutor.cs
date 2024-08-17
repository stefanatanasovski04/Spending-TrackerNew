namespace SpendingSolution.Common.Mediator
{
    using SpendingSolution.Common.Mediator.Contracts;

    public class CustomCommandExecutor : ICustomCommandExecutor
    {
        private readonly CustomMediator mediator;

        public CustomCommandExecutor(CustomMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task Execute<TCommand>(TCommand command) where TCommand : CustomCommand
        {
            await mediator.Send(command);
        }

        public async Task<TResult> Execute<TCommand, TResult>(TCommand command)
            where TCommand : CustomCommand
            where TResult : class
        {
            return await mediator.Send<TCommand, TResult>(command);
        }
    }
}
