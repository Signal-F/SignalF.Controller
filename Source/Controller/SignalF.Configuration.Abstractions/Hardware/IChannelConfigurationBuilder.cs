﻿using SignalF.Controller.Configuration;
using SignalF.Datamodel.Hardware;

namespace SignalF.Configuration.Hardware;

public interface IChannelConfigurationBuilder : IChannelConfigurationBuilder<IChannelConfigurationBuilder, IChannelConfiguration, CoreConfigurationOptions>
{
}

public interface IChannelConfigurationBuilder<out TBuilder, in TConfiguration, in TOptions>
    : ICoreConfigurationBuilder<TBuilder, TConfiguration, TOptions>
    where TBuilder : IChannelConfigurationBuilder<TBuilder, TConfiguration, TOptions>
    where TConfiguration : IChannelConfiguration
    where TOptions : CoreConfigurationOptions
{
}