using Newtonsoft.Json;
using System.Collections.Generic;

namespace PyrusApiClient
{
	public class VisibilityCondition
	{
		[JsonProperty("field_id")]
		public int FieldId { get; set; }

		[JsonProperty("condition_type")]
		public int ConditionType { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("children")]
		public List<VisibilityCondition> Children { get; set; }
	}
}
