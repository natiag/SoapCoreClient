using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Version0;
using Version1;
using Version2;
using Version3;
using Version4;
using Version5;
using Version6;
using Version7;

namespace SoapTest.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob]
    [InvocationCount(2)]
    [WarmupCount(2)]
    [IterationCount(10)]
    public class GetRatesQueryBenchmark
    {
        private IServiceProvider _serviceProvider;
        [GlobalSetup]
        public void GlobalSetup()
        {
            var servicesCollection = new ServiceCollection();
            var services = new DefaultServiceProviderFactory().CreateBuilder(servicesCollection);
            services.AddVersion0();
            services.AddVersion1();
            services.AddVersion2();
            services.AddVersion3();
            services.AddVersion4();
            services.AddVersion5();
            services.AddVersion6();
            services.AddVersion7();
            //services.AddVersion8();
            //services.AddVersion9();

            _serviceProvider = services.BuildServiceProvider();
        }

        [Benchmark(Baseline = true, OperationsPerInvoke = 1)]
        public IReadOnlyCollection<Common.CurrencyRateModel> Version0()
        {
            var getRatesQuery = _serviceProvider.GetRequiredService<Version0.GetLariRatesQuery>(); 
            getRatesQuery.Execute();
            return getRatesQuery.Execute();
        }

        [Benchmark(OperationsPerInvoke = 1)]
        public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version1()
        {
            var getRatesQuery = _serviceProvider.GetRequiredService<Version1.GetLariRatesQuery>();
            await getRatesQuery.Execute();
            return await getRatesQuery.Execute();
        }

        [Benchmark(OperationsPerInvoke = 1)]
        public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version2()
        {
            var getRatesQuery = _serviceProvider.GetRequiredService<Version2.GetLariRatesQuery>();
            await getRatesQuery.Execute();
            return await getRatesQuery.Execute();
        }

        [Benchmark(OperationsPerInvoke = 1)]
        public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version3()
        {
            var getRatesQuery = _serviceProvider.GetRequiredService<Version3.GetLariRatesQuery>();
            await getRatesQuery.Execute();
            return await getRatesQuery.Execute();
        }

        [Benchmark(OperationsPerInvoke = 1)]
        public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version4()
        {
            var getRatesQuery = _serviceProvider.GetRequiredService<Version4.GetLariRatesQuery>(); 
            await getRatesQuery.Execute(); 
            return await getRatesQuery.Execute();
        }

        [Benchmark(OperationsPerInvoke = 1)]
        public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version5()
        {
            var getRatesQuery = _serviceProvider.GetRequiredService<Version5.GetLariRatesQuery>(); 
            await getRatesQuery.Execute();
            return await getRatesQuery.Execute();
        }

        [Benchmark(OperationsPerInvoke = 1)]
        public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version6()
        {
            var getRatesQuery = _serviceProvider.GetRequiredService<Version6.GetLariRatesQuery>(); 
            await getRatesQuery.Execute(); 
            return await getRatesQuery.Execute();
        }

        [Benchmark(OperationsPerInvoke = 1)]
        public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version7()
        {
            var getRatesQuery = _serviceProvider.GetRequiredService<Version7.GetLariRatesQuery>(); await getRatesQuery.Execute();
            return await getRatesQuery.Execute();
        }

        //[Benchmark(OperationsPerInvoke = 1)]
        //public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version8()
        //{
        //    var getRatesQuery = _serviceProvider.GetRequiredService<Version8.GetLariRatesQuery>();
        //    return await getRatesQuery.Execute();
        //}

        //[Benchmark(OperationsPerInvoke = 1)]
        //public async Task<IReadOnlyCollection<Common.CurrencyRateModel>> Version9()
        //{
        //    var getRatesQuery = _serviceProvider.GetRequiredService<Version9.GetLariRatesQuery>();
        //    return await getRatesQuery.Execute();
        //}
    }
}

