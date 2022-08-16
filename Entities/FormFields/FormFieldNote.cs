using Newtonsoft.Json;
using System.Collections.Generic;

namespace PyrusApiClient
{
	public class FormFieldNote : FormField
	{
		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("tooltip")]
		public string Tooltip { get; set; }

		[JsonProperty("visibility_condition")]
		public VisibilityCondition VisibilityCondition { get; set; }

		public override string ToString()
		{
			return Value ?? "";
		}
	}
}