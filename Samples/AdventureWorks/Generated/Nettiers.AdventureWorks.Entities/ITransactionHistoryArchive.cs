﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'TransactionHistoryArchive' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface ITransactionHistoryArchive 
	{
		/// <summary>			
		/// TransactionID : Primary key for TransactionHistoryArchive records.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "TransactionHistoryArchive"</remarks>
		System.Int32 TransactionId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalTransactionId { get; set; }
			
		
		
		/// <summary>
		/// ProductID : Product identification number. Foreign key to Product.ProductID.
		/// </summary>
		System.Int32  ProductId  { get; set; }
		
		/// <summary>
		/// ReferenceOrderID : Purchase order, sales order, or work order identification number.
		/// </summary>
		System.Int32  ReferenceOrderId  { get; set; }
		
		/// <summary>
		/// ReferenceOrderLineID : Line number associated with the purchase order, sales order, or work order.
		/// </summary>
		System.Int32  ReferenceOrderLineId  { get; set; }
		
		/// <summary>
		/// TransactionDate : Date and time of the transaction.
		/// </summary>
		System.DateTime  TransactionDate  { get; set; }
		
		/// <summary>
		/// TransactionType : W = Work Order, S = Sales Order, P = Purchase Order
		/// </summary>
		System.String  TransactionType  { get; set; }
		
		/// <summary>
		/// Quantity : Product quantity.
		/// </summary>
		System.Int32  Quantity  { get; set; }
		
		/// <summary>
		/// ActualCost : Product cost.
		/// </summary>
		System.Decimal  ActualCost  { get; set; }
		
		/// <summary>
		/// ModifiedDate : Date and time the record was last updated.
		/// </summary>
		System.DateTime  ModifiedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}

