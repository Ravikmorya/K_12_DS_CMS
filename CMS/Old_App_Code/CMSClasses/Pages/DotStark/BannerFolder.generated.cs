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

[assembly: RegisterDocumentType(BannerFolder.CLASS_NAME, typeof(BannerFolder))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type BannerFolder.
	/// </summary>
	public partial class BannerFolder : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.BannerFolder";


		/// <summary>
		/// The instance of the class that provides extended API for working with BannerFolder fields.
		/// </summary>
		private readonly BannerFolderFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// Gets an object that provides extended API for working with BannerFolder fields.
		/// </summary>
		[RegisterProperty]
		public BannerFolderFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with BannerFolder fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class BannerFolderFields : AbstractHierarchicalObject<BannerFolderFields>
		{
			/// <summary>
			/// The content item of type BannerFolder that is a target of the extended API.
			/// </summary>
			private readonly BannerFolder mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="BannerFolderFields" /> class with the specified content item of type BannerFolder.
			/// </summary>
			/// <param name="instance">The content item of type BannerFolder that is a target of the extended API.</param>
			public BannerFolderFields(BannerFolder instance)
			{
				mInstance = instance;
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="BannerFolder" /> class.
		/// </summary>
		public BannerFolder() : base(CLASS_NAME)
		{
			mFields = new BannerFolderFields(this);
		}

		#endregion
	}
}