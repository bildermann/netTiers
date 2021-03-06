﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'Vendor' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IVendor 
	{
		/// <summary>			
		/// VendorID : Primary key for Vendor records.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Vendor"</remarks>
		System.Int32 VendorId { get; set; }
				
		
		
		/// <summary>
		/// AccountNumber : Vendor account (identification) number.
		/// </summary>
		System.String  AccountNumber  { get; set; }
		
		/// <summary>
		/// Name : Company name.
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// CreditRating : 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average
		/// </summary>
		System.Byte  CreditRating  { get; set; }
		
		/// <summary>
		/// PreferredVendorStatus : 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.
		/// </summary>
		System.Boolean  PreferredVendorStatus  { get; set; }
		
		/// <summary>
		/// ActiveFlag : 0 = Vendor no longer used. 1 = Vendor is actively used.
		/// </summary>
		System.Boolean  ActiveFlag  { get; set; }
		
		/// <summary>
		/// PurchasingWebServiceURL : Vendor URL.
		/// </summary>
		System.String  PurchasingWebServiceUrl  { get; set; }
		
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


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _vendorAddressVendorId
		/// </summary>	
		TList<VendorAddress> VendorAddressCollection {  get;  set;}	

		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the junction table productIdProductCollectionFromProductVendor
		/// </summary>	
		TList<Product> ProductIdProductCollection_From_ProductVendor { get; set; }	

		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the junction table addressIdAddressCollectionFromVendorAddress
		/// </summary>	
		TList<Address> AddressIdAddressCollection_From_VendorAddress { get; set; }	

		
		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the junction table contactIdContactCollectionFromVendorContact
		/// </summary>	
		TList<Contact> ContactIdContactCollection_From_VendorContact { get; set; }	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _vendorContactVendorId
		/// </summary>	
		TList<VendorContact> VendorContactCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _purchaseOrderHeaderVendorId
		/// </summary>	
		TList<PurchaseOrderHeader> PurchaseOrderHeaderCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _productVendorVendorId
		/// </summary>	
		TList<ProductVendor> ProductVendorCollection {  get;  set;}	

		#endregion Data Properties

	}
}


