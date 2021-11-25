//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.DotStark;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(ImageItem.CLASS_NAME, typeof(ImageItem))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type ImageItem.
	/// </summary>
	public partial class ImageItem : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.ImageItem";


		/// <summary>
		/// The instance of the class that provides extended API for working with ImageItem fields.
		/// </summary>
		private readonly ImageItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ImageItemID.
		/// </summary>
		[DatabaseIDField]
		public int ImageItemID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ImageItemID"), 0);
			}
			set
			{
				SetValue("ImageItemID", value);
			}
		}


		/// <summary>
		/// Banner.
		/// </summary>
		[DatabaseField]
		public Guid ImageItemBanner
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ImageItemBanner"), Guid.Empty);
			}
			set
			{
				SetValue("ImageItemBanner", value);
			}
		}


		/// <summary>
		/// Img Pen.
		/// </summary>
		[DatabaseField]
		public Guid ImageItemImgPen
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ImageItemImgPen"), Guid.Empty);
			}
			set
			{
				SetValue("ImageItemImgPen", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string ImageItemText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ImageItemText"), @"");
			}
			set
			{
				SetValue("ImageItemText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ImageItem fields.
		/// </summary>
		[RegisterProperty]
		public ImageItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ImageItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ImageItemFields : AbstractHierarchicalObject<ImageItemFields>
		{
			/// <summary>
			/// The content item of type ImageItem that is a target of the extended API.
			/// </summary>
			private readonly ImageItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ImageItemFields" /> class with the specified content item of type ImageItem.
			/// </summary>
			/// <param name="instance">The content item of type ImageItem that is a target of the extended API.</param>
			public ImageItemFields(ImageItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ImageItemID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ImageItemID;
				}
				set
				{
					mInstance.ImageItemID = value;
				}
			}


			/// <summary>
			/// Banner.
			/// </summary>
			public DocumentAttachment Banner
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ImageItemBanner");
				}
			}


			/// <summary>
			/// Img Pen.
			/// </summary>
			public DocumentAttachment ImgPen
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ImageItemImgPen");
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.ImageItemText;
				}
				set
				{
					mInstance.ImageItemText = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ImageItem" /> class.
		/// </summary>
		public ImageItem() : base(CLASS_NAME)
		{
			mFields = new ImageItemFields(this);
		}

		#endregion
	}
}