﻿using System;
using Scotec.XMLDatabase;


namespace SignalF.Datamodel.Units
{
	public partial class MassUnit : SignalF.Datamodel.Units.Unit, SignalF.Datamodel.Units.IMassUnit
	{
		#region Properties

		
		private const string UNIT_PROPERTY_NAME = "Unit";		
		Scotec.Math.Units.Mass.Units IMassUnit.Unit
		{
			get
			{
				try
				{
					return ((SignalF.Datamodel.Units.IMass)BusinessSession.Factory.GetBusinessAttribute(DataObject.GetAttribute(UNIT_PROPERTY_NAME))).Value;
				}
				catch(Scotec.XMLDatabase.DataException e)
				{
					throw new BusinessException((EBusinessError)e.DataError, e.Message, e);
				}
				catch(Exception e)
				{
					throw new BusinessException(EBusinessError.Document, "Caught unhandled exception.", e);
				}
			}
			set
			{
				try
				{
					var attribute = (SignalF.Datamodel.Units.IMass)BusinessSession.Factory.GetBusinessAttribute(DataObject.GetAttribute(UNIT_PROPERTY_NAME));
					
					if(attribute.Value == (Scotec.Math.Units.Mass.Units)value)
						return;
					
					attribute.Value = (Scotec.Math.Units.Mass.Units)value;
					AddModifiedProperty(UNIT_PROPERTY_NAME);
				}
				catch(Scotec.XMLDatabase.DataException e)
				{
					throw new BusinessException((EBusinessError)e.DataError, e.Message, e);
				}
				catch(Exception e)
				{
					throw new BusinessException(EBusinessError.Document, "Caught unhandled exception.", e);
				}
			}
		}
		#endregion Properties


		#region Interface Implementations

		public override TResult Apply<TResult>(IVisitor<TResult> visitor)
		{
			var specificVisitor = visitor as IMassUnitVisitor<TResult>;
			return (specificVisitor != null) ? specificVisitor.Visit(this) : base.Apply(visitor);
		}

		#endregion Interface Implementations

	}
}

