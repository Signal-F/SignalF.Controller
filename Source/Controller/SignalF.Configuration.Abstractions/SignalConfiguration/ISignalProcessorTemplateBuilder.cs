﻿using SignalF.Controller.Configuration;
using SignalF.Datamodel.Signals;

namespace SignalF.Configuration.SignalConfiguration;

public interface
    ISignalProcessorTemplateBuilder : ISignalProcessorTemplateBuilder<ISignalProcessorTemplateBuilder, ISignalProcessorTemplate, CoreConfigurationOptions>
{
}

public interface ISignalProcessorTemplateBuilder<out TBuilder, in TConfiguration, in TOptions> : ICoreConfigurationBuilder<TBuilder, TConfiguration, TOptions>
    where TBuilder : ISignalProcessorTemplateBuilder<TBuilder, TConfiguration, TOptions>
    where TConfiguration : ISignalProcessorTemplate
    where TOptions : CoreConfigurationOptions
{
    TBuilder AddSignalSourceDefinition(string defaultName);

    TBuilder AddSignalSourceDefinition(string defaultName, EUnitType unitType);

    TBuilder AddSignalSinkDefinition(string defaultName);

    TBuilder AddSignalSinkDefinition(string defaultName, EUnitType unitType);
}