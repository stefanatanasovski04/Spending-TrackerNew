namespace SpendingSolution.Common.Mediator
{
    using SpendingSolution.Common.Mediator.Contracts;

    public interface ICustomCommandExecutor
    {
        Task Execute<TCommand>(TCommand command)
            where TCommand : CustomCommand;

        Task<TResult> Execute<TCommand, TResult>(TCommand command)
            where TCommand : CustomCommand
            where TResult : class;
    }
}
