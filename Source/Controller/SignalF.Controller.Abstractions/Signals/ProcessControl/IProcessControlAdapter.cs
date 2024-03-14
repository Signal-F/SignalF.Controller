﻿#region

#endregion

using SignalF.Controller.Signals.SignalProcessor;

namespace SignalF.Controller.Signals.ProcessControl;

/// <summary>
///     Used to exchange signals between the signal hub and the process control procedure
/// </summary>
public interface IProcessControlAdapter : ISignalProcessor
{
    long Timestamp { get; }

    /// <summary>
    ///     Reads all signal values currently stored in the ExecutionAdapter.
    /// </summary>
    /// <returns>Array containing the double values.</returns>
    double[] ReadValues();

    /// <summary>
    ///     Writes the given signal values to the ExecutionAdapter.
    /// </summary>
    /// <param name="values">A Dictionary containing the signal indexes and values to be written.</param>
    void WriteValues(double[] values);

    /// <summary>
    ///     Gets the value of the desired signal.
    /// </summary>
    /// <param name="signalName">The name of the signal.</param>
    /// <returns></returns>
    double GetValue(string signalName);

    /// <summary>
    ///     Sets the signal to the desired value if it exists.
    /// </summary>
    /// <param name="signalName">The name of the signal.</param>
    /// <param name="value">The value to set the signal to.</param>
    void SetValue(string signalName, double value);
}