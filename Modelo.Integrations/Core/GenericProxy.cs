using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace MRV.Terrenos.Infra.DataAgentsS.Core
{
    internal sealed class GenericProxy<TContract> : IDisposable where TContract : class
    {
        private readonly ChannelFactory<TContract> _channelFactory;
        private TContract _channel;

        public GenericProxy(Binding binding, EndpointAddress remoteAddress)
        {
            _channelFactory = new ChannelFactory<TContract>(binding, remoteAddress);
        }

        public GenericProxy(string endpointConfiguration, EndpointAddress remoteAddress)
        {
            _channelFactory = new ChannelFactory<TContract>(endpointConfiguration, remoteAddress);
        }

        public void Execute(Action<TContract> action)
        {
            action.Invoke(Channel);
        }

        public TResult Execute<TResult>(Func<TContract, TResult> function)
        {
            return function.Invoke(Channel);
        }

        private TContract Channel
        {
            get
            {
                if (_channel == null)
                {
                    _channel = _channelFactory.CreateChannel();
                }

                return _channel;
            }
        }

        public void Dispose()
        {
            try
            {
                if (_channel != null)
                {
                    var currentChannel = _channel as IClientChannel;
                    if (currentChannel != null && currentChannel.State == CommunicationState.Faulted)
                    {
                        currentChannel.Abort();
                    }
                    else
                    {
                        currentChannel?.Close();
                    }
                }
            }
            finally
            {
                _channel = null;
                GC.SuppressFinalize(this);
            }
        }
    }
}
