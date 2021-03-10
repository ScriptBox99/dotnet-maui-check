﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace MauiDoctor.Manifest
{
	public partial class Android
	{
		[JsonProperty("packages")]
		public List<AndroidPackage> Packages { get; set; }
	}
}