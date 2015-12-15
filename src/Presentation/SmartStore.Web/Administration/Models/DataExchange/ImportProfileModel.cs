﻿using System.Collections.Generic;
using System.Web.Mvc;
using FluentValidation.Attributes;
using SmartStore.Admin.Models.Tasks;
using SmartStore.Admin.Validators.DataExchange;
using SmartStore.Core.Domain.DataExchange;
using SmartStore.Web.Framework;
using SmartStore.Web.Framework.Modelling;

namespace SmartStore.Admin.Models.DataExchange
{
	[Validator(typeof(ImportProfileValidator))]
	public partial class ImportProfileModel : EntityModelBase
	{
		[SmartResourceDisplayName("Admin.DataExchange.Import.Name")]
		public string Name { get; set; }

		[SmartResourceDisplayName("Admin.DataExchange.Import.FileType")]
		public ImportFileType FileType { get; set; }
		public List<SelectListItem> AvailableFileTypes { get; set; }

		[SmartResourceDisplayName("Admin.Common.ImportFiles")]
		public List<string> ExistingFileNames { get; set; }

		[SmartResourceDisplayName("Admin.Common.Entity")]
		public ImportEntityType EntityType { get; set; }
		public string EntityTypeName { get; set; }
		public List<SelectListItem> AvailableEntityTypes { get; set; }

		[SmartResourceDisplayName("Common.Enabled")]
		public bool Enabled { get; set; }

		[SmartResourceDisplayName("Admin.Common.RecordsSkip")]
		public int Skip { get; set; }

		[SmartResourceDisplayName("Admin.Common.RecordsTake")]
		public int Take { get; set; }

		[SmartResourceDisplayName("Common.Execution")]
		public int ScheduleTaskId { get; set; }
		public string ScheduleTaskName { get; set; }
		public bool IsTaskRunning { get; set; }
		public bool IsTaskEnabled { get; set; }

		public ScheduleTaskModel TaskModel { get; set; }
		public bool LogFileExists { get; set; }
		public string TempFileName { get; set; }

		public CsvConfigurationModel CsvConfiguration { get; set; }
	}
}