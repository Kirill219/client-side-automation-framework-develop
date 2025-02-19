﻿using System;
using System.Linq;
using Autofac;
using Kpi.UkrNet.ClientTests.Bootstrap;
using Microsoft.Extensions.Configuration;
using SpecFlow.Autofac;
using TechTalk.SpecFlow;

namespace Kpi.UkrNet.ClientTests.Tests.Hooks
{
    public class TestDependencies
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            var builder = new Bootstraper();
            builder.ConfigureServices(GetConfiguration());
            builder.Builder.RegisterTypes(
                typeof(TestDependencies)
                    .Assembly.GetTypes()
                    .Where(t => Attribute.IsDefined(t, typeof(BindingAttribute)))
                    .ToArray()).InstancePerLifetimeScope();
            return builder.Builder;
        }

        private static IConfigurationBuilder GetConfiguration()
        {
            var ciEnv = Environment.GetEnvironmentVariable("testrun.environment");
            var val = string.IsNullOrEmpty(ciEnv) ? "chrome.int" : ciEnv;

            return new ConfigurationBuilder()
                .AddJsonFile($"env.{val}.json", optional: true, reloadOnChange: true)
                .AddJsonFile("runsettings.json", optional: true, reloadOnChange: true);
        }
    }
}
