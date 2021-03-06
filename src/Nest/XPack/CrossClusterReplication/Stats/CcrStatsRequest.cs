﻿using Nest.Specification.CrossClusterReplicationApi;

namespace Nest
{
	/// <summary>
	/// Gets cross-cluster replication stats. Returns all stats related to cross-cluster replication.
	/// In particular, this API returns stats about auto-following, and returns the same shard-level stats as in the get
	/// follower stats API. <see cref="CrossClusterReplicationNamespace.FollowIndexStats(Nest.Indices,System.Func{Nest.FollowIndexStatsDescriptor,Nest.IFollowIndexStatsRequest})"/>
	/// </summary>
	[MapsApi("ccr.stats.json")]
	[ReadAs(typeof(CcrStatsRequest))]
	public partial interface ICcrStatsRequest { }

	/// <inheritdoc cref="ICcrStatsRequest"/>
	public partial class CcrStatsRequest { }

	/// <inheritdoc cref="ICcrStatsRequest"/>
	public partial class CcrStatsDescriptor { }
}
