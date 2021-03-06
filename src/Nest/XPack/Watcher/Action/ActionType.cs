﻿using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	[StringEnum]
	public enum ActionType
	{
		[EnumMember(Value = "email")]
		Email,

		[EnumMember(Value = "webhook")]
		Webhook,

		[EnumMember(Value = "index")]
		Index,

		[EnumMember(Value = "logging")]
		Logging,

		[EnumMember(Value = "slack")]
		Slack,

		[EnumMember(Value = "pagerduty")]
		PagerDuty,
	}
}
