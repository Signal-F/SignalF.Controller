﻿using System;
using Scotec.XMLDatabase;


namespace SignalF.Datamodel.Devices
{
	public partial class SI7021Template : SignalF.Datamodel.Hardware.DeviceTemplate, SignalF.Datamodel.Devices.ISI7021Template
	{
		#region Properties

		#endregion Properties


		#region Interface Implementations

		public override TResult Apply<TResult>(IVisitor<TResult> visitor)
		{
			var specificVisitor = visitor as ISI7021TemplateVisitor<TResult>;
			return (specificVisitor != null) ? specificVisitor.Visit(this) : base.Apply(visitor);
		}

		#endregion Interface Implementations

	}
}

