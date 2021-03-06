// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nest
{
	public class ClearCachedRolesResponse : ResponseBase
	{
		[DataMember(Name = "cluster_name")]
		public string ClusterName { get; internal set; }

		[DataMember(Name = "nodes")]
		public IReadOnlyDictionary<string, SecurityNode> Nodes { get; internal set; } = EmptyReadOnly<string, SecurityNode>.Dictionary;
	}
}
