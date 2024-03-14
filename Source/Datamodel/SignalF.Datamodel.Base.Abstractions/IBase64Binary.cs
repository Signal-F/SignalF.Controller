﻿using System;
using Scotec.XMLDatabase;


namespace SignalF.Datamodel.Base
{
	public partial interface IBase64Binary
	{

		#region Properties

		System.Byte[] Value{get;set;}

		System.Byte[] DefaultValue{get;}

		#endregion Properties


		#region Methods

		bool Validate(System.Byte[] value);

		#endregion Methods

	}
}
