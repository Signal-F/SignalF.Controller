﻿using System;
using SignalF.Configuration.Devices;
using SignalF.Controller.Configuration;
using SignalF.Controller.Signals.Devices;

namespace SignalF.Configuration;

public partial interface ISignalFConfiguration
{
    ISignalFConfiguration AddDeviceConfiguration<TBuilder, TOptions>(Action<TBuilder> builder)
        where TBuilder : IDeviceConfigurationBuilder
        where TOptions : SignalFConfigurationOptions;

    ISignalFConfiguration AddDeviceConfiguration<TBuilder, TOptions, TType>(Action<TBuilder> builder)
        where TBuilder : IDeviceConfigurationBuilder
        where TOptions : SignalFConfigurationOptions
        where TType : class, IDevice;

    ISignalFConfiguration AddDeviceDefinition<TBuilder, TOptions>(Action<TBuilder> builder)
        where TBuilder : IDeviceDefinitionBuilder
        where TOptions : SignalFConfigurationOptions;

    ISignalFConfiguration AddDeviceDefinition<TBuilder, TOptions, TType>(Action<TBuilder> builder)
        where TBuilder : IDeviceDefinitionBuilder
        where TOptions : SignalFConfigurationOptions
        where TType : class, IDevice;

    ISignalFConfiguration AddDeviceTemplate<TBuilder, TOptions>(Action<TBuilder> builder)
        where TBuilder : IDeviceTemplateBuilder
        where TOptions : SignalFConfigurationOptions;

    ISignalFConfiguration AddDeviceTemplate<TBuilder, TOptions, TType>(Action<TBuilder> action)
        where TBuilder : IDeviceTemplateBuilder
        where TOptions : SignalFConfigurationOptions
        where TType : class, IDevice;
}