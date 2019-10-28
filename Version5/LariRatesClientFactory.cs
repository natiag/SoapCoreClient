using Microsoft.Extensions.DependencyInjection;
using System;

namespace Version5
{
    public class LariRatesClientFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public LariRatesClientFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public LariRatesClient Create()
        {
            return _serviceProvider.GetRequiredService<LariRatesClient>();
        }
    }
}
