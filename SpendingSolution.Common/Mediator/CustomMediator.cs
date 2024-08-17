namespace SpendingSolution.Common.Mediator
{
    using MassTransit.Mediator;
    using MassTransit;
    using SpendingSolution.Common.Mediator.Contracts;

    public class CustomMediator
    {
        private readonly IMediator massTransitMediator;

        public CustomMediator(IMediator massTransitMediator)
        {
            this.massTransitMediator = massTransitMediator;
        }

        public async Task Publish(object @event, Type eventType)
        {
            await massTransitMediator.Publish(@event, eventType);
        }

        public async Task Send<TMessage>(TMessage command)
            where TMessage : CustomMessage
        {
            await massTransitMediator.Send(command);
        }

        public async Task<TResult> Send<TMessage, TResult>(TMessage command)
            where TMessage : CustomMessage
            where TResult : class
        {
            IRequestClient<TMessage> requestClient = massTransitMediator.CreateRequestClient<TMessage>();

            Response<TResult> response = await requestClient.GetResponse<TResult>(command);
            return response.Message;
        }
    }
}
