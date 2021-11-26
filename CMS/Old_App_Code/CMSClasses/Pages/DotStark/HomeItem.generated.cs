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

[assembly: RegisterDocumentType(HomeItem.CLASS_NAME, typeof(HomeItem))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type HomeItem.
	/// </summary>
	public partial class HomeItem : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.HomeItem";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeItem fields.
		/// </summary>
		private readonly HomeItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeItemID.
		/// </summary>
		[DatabaseIDField]
		public int HomeItemID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeItemID"), 0);
			}
			set
			{
				SetValue("HomeItemID", value);
			}
		}


		/// <summary>
		/// Head1.
		/// </summary>
		[DatabaseField]
		public string HomeItemHead1
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemHead1"), @"");
			}
			set
			{
				SetValue("HomeItemHead1", value);
			}
		}


		/// <summary>
		/// Head2.
		/// </summary>
		[DatabaseField]
		public string HomeItemHead2
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemHead2"), @"");
			}
			set
			{
				SetValue("HomeItemHead2", value);
			}
		}


		/// <summary>
		/// Head3.
		/// </summary>
		[DatabaseField]
		public string HomeItemHead3
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemHead3"), @"");
			}
			set
			{
				SetValue("HomeItemHead3", value);
			}
		}


		/// <summary>
		/// RISEON.
		/// </summary>
		[DatabaseField]
		public string HomeItemRISEON
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemRISEON"), @"");
			}
			set
			{
				SetValue("HomeItemRISEON", value);
			}
		}


		/// <summary>
		/// STARK.
		/// </summary>
		[DatabaseField]
		public string HomeItemSTARK
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemSTARK"), @"");
			}
			set
			{
				SetValue("HomeItemSTARK", value);
			}
		}


		/// <summary>
		/// Whatsgoing.
		/// </summary>
		[DatabaseField]
		public string HomeItemWhatsgoing
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemWhatsgoing"), @"");
			}
			set
			{
				SetValue("HomeItemWhatsgoing", value);
			}
		}


		/// <summary>
		/// Kentico Experts.
		/// </summary>
		[DatabaseField]
		public string HomeItemKenticoExperts
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemKenticoExperts"), @"");
			}
			set
			{
				SetValue("HomeItemKenticoExperts", value);
			}
		}


		/// <summary>
		/// Partner.
		/// </summary>
		[DatabaseField]
		public string HomeItemPartner
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemPartner"), @"");
			}
			set
			{
				SetValue("HomeItemPartner", value);
			}
		}


		/// <summary>
		/// Explore Possibilities.
		/// </summary>
		[DatabaseField]
		public string HomeItemExplorePossibilities
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemExplorePossibilities"), @"");
			}
			set
			{
				SetValue("HomeItemExplorePossibilities", value);
			}
		}


		/// <summary>
		/// Speak.
		/// </summary>
		[DatabaseField]
		public string HomeItemSpeak
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemSpeak"), @"");
			}
			set
			{
				SetValue("HomeItemSpeak", value);
			}
		}


		/// <summary>
		/// Xperience.
		/// </summary>
		[DatabaseField]
		public Guid HomeItemXperience
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("HomeItemXperience"), Guid.Empty);
			}
			set
			{
				SetValue("HomeItemXperience", value);
			}
		}


		/// <summary>
		/// KenticoC.
		/// </summary>
		[DatabaseField]
		public Guid HomeItemKenticoC
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("HomeItemKenticoC"), Guid.Empty);
			}
			set
			{
				SetValue("HomeItemKenticoC", value);
			}
		}


		/// <summary>
		/// KenticoBro.
		/// </summary>
		[DatabaseField]
		public Guid HomeItemKenticoBro
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("HomeItemKenticoBro"), Guid.Empty);
			}
			set
			{
				SetValue("HomeItemKenticoBro", value);
			}
		}


		/// <summary>
		/// Read more page.
		/// </summary>
		[DatabaseField]
		public string HomeItemLinkText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeItemLinkText"), @"");
			}
			set
			{
				SetValue("HomeItemLinkText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomeItem fields.
		/// </summary>
		[RegisterProperty]
		public HomeItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomeItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeItemFields : AbstractHierarchicalObject<HomeItemFields>
		{
			/// <summary>
			/// The content item of type HomeItem that is a target of the extended API.
			/// </summary>
			private readonly HomeItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeItemFields" /> class with the specified content item of type HomeItem.
			/// </summary>
			/// <param name="instance">The content item of type HomeItem that is a target of the extended API.</param>
			public HomeItemFields(HomeItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeItemID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeItemID;
				}
				set
				{
					mInstance.HomeItemID = value;
				}
			}


			/// <summary>
			/// Head1.
			/// </summary>
			public string Head1
			{
				get
				{
					return mInstance.HomeItemHead1;
				}
				set
				{
					mInstance.HomeItemHead1 = value;
				}
			}


			/// <summary>
			/// Head2.
			/// </summary>
			public string Head2
			{
				get
				{
					return mInstance.HomeItemHead2;
				}
				set
				{
					mInstance.HomeItemHead2 = value;
				}
			}


			/// <summary>
			/// Head3.
			/// </summary>
			public string Head3
			{
				get
				{
					return mInstance.HomeItemHead3;
				}
				set
				{
					mInstance.HomeItemHead3 = value;
				}
			}


			/// <summary>
			/// RISEON.
			/// </summary>
			public string RISEON
			{
				get
				{
					return mInstance.HomeItemRISEON;
				}
				set
				{
					mInstance.HomeItemRISEON = value;
				}
			}


			/// <summary>
			/// STARK.
			/// </summary>
			public string STARK
			{
				get
				{
					return mInstance.HomeItemSTARK;
				}
				set
				{
					mInstance.HomeItemSTARK = value;
				}
			}


			/// <summary>
			/// Whatsgoing.
			/// </summary>
			public string Whatsgoing
			{
				get
				{
					return mInstance.HomeItemWhatsgoing;
				}
				set
				{
					mInstance.HomeItemWhatsgoing = value;
				}
			}


			/// <summary>
			/// Kentico Experts.
			/// </summary>
			public string KenticoExperts
			{
				get
				{
					return mInstance.HomeItemKenticoExperts;
				}
				set
				{
					mInstance.HomeItemKenticoExperts = value;
				}
			}


			/// <summary>
			/// Partner.
			/// </summary>
			public string Partner
			{
				get
				{
					return mInstance.HomeItemPartner;
				}
				set
				{
					mInstance.HomeItemPartner = value;
				}
			}


			/// <summary>
			/// Explore Possibilities.
			/// </summary>
			public string ExplorePossibilities
			{
				get
				{
					return mInstance.HomeItemExplorePossibilities;
				}
				set
				{
					mInstance.HomeItemExplorePossibilities = value;
				}
			}


			/// <summary>
			/// Speak.
			/// </summary>
			public string Speak
			{
				get
				{
					return mInstance.HomeItemSpeak;
				}
				set
				{
					mInstance.HomeItemSpeak = value;
				}
			}


			/// <summary>
			/// Xperience.
			/// </summary>
			public DocumentAttachment Xperience
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("HomeItemXperience");
				}
			}


			/// <summary>
			/// KenticoC.
			/// </summary>
			public DocumentAttachment KenticoC
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("HomeItemKenticoC");
				}
			}


			/// <summary>
			/// KenticoBro.
			/// </summary>
			public DocumentAttachment KenticoBro
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("HomeItemKenticoBro");
				}
			}


			/// <summary>
			/// Read more page.
			/// </summary>
			public string LinkText
			{
				get
				{
					return mInstance.HomeItemLinkText;
				}
				set
				{
					mInstance.HomeItemLinkText = value;
				}
			}


			/// <summary>
			/// Read more page.
			/// </summary>
			public IEnumerable<TreeNode> Link
			{
				get
				{
					return mInstance.GetRelatedDocuments("HomeItemLink");
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeItem" /> class.
		/// </summary>
		public HomeItem() : base(CLASS_NAME)
		{
			mFields = new HomeItemFields(this);
		}

		#endregion
	}
}