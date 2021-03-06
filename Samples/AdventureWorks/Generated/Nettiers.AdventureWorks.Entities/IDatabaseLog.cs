﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'DatabaseLog' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IDatabaseLog 
	{
		/// <summary>			
		/// DatabaseLogID : Primary key for DatabaseLog records.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "DatabaseLog"</remarks>
		System.Int32 DatabaseLogId { get; set; }
				
		
		
		/// <summary>
		/// PostTime : The date and time the DDL change occurred.
		/// </summary>
		System.DateTime  PostTime  { get; set; }
		
		/// <summary>
		/// DatabaseUser : The user who implemented the DDL change.
		/// </summary>
		System.String  DatabaseUser  { get; set; }
		
		/// <summary>
		/// Event : The type of DDL statement that was executed.
		/// </summary>
		System.String  SafeNameEvent  { get; set; }
		
		/// <summary>
		/// Schema : The schema to which the changed object belongs.
		/// </summary>
		System.String  Schema  { get; set; }
		
		/// <summary>
		/// Object : The object that was changed by the DDL statment.
		/// </summary>
		System.String  SafeNameObject  { get; set; }
		
		/// <summary>
		/// TSQL : The exact Transact-SQL statement that was executed.
		/// </summary>
		System.String  Tsql  { get; set; }
		
		/// <summary>
		/// XmlEvent : The raw XML data generated by database trigger.
		/// </summary>
		string  XmlEvent  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


