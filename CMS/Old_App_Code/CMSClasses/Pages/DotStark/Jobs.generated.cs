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

[assembly: RegisterDocumentType(Jobs.CLASS_NAME, typeof(Jobs))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type Jobs.
	/// </summary>
	public partial class Jobs : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.Jobs";


		/// <summary>
		/// The instance of the class that provides extended API for working with Jobs fields.
		/// </summary>
		private readonly JobsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// JobsID.
		/// </summary>
		[DatabaseIDField]
		public int JobsID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("JobsID"), 0);
			}
			set
			{
				SetValue("JobsID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string JobsName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("JobsName"), @"");
			}
			set
			{
				SetValue("JobsName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Jobs fields.
		/// </summary>
		[RegisterProperty]
		public JobsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Jobs fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class JobsFields : AbstractHierarchicalObject<JobsFields>
		{
			/// <summary>
			/// The content item of type Jobs that is a target of the extended API.
			/// </summary>
			private readonly Jobs mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="JobsFields" /> class with the specified content item of type Jobs.
			/// </summary>
			/// <param name="instance">The content item of type Jobs that is a target of the extended API.</param>
			public JobsFields(Jobs instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// JobsID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.JobsID;
				}
				set
				{
					mInstance.JobsID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.JobsName;
				}
				set
				{
					mInstance.JobsName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Jobs" /> class.
		/// </summary>
		public Jobs() : base(CLASS_NAME)
		{
			mFields = new JobsFields(this);
		}

		#endregion
	}
}