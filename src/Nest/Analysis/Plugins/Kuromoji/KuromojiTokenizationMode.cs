// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

﻿using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	/// <summary>
	/// The tokenization mode determines how the tokenizer handles compound and unknown words.
	/// Part of the `analysis-kuromoji` plugin:
	/// https://www.elastic.co/guide/en/elasticsearch/plugins/current/analysis-kuromoji.html
	/// </summary>
	[StringEnum]
	public enum KuromojiTokenizationMode
	{
		/// <summary>
		/// Normal segmentation, no decomposition for compounds
		/// </summary>
		[EnumMember(Value = "normal")]
		Normal,

		/// <summary>
		/// Segmentation geared towards search. This includes a decompounding process for long nouns,
		/// also including the full compound token as a synonym.
		/// </summary>
		[EnumMember(Value = "search")]
		Search,

		/// <summary>
		/// Extended mode outputs unigrams for unknown words.
		/// </summary>
		[EnumMember(Value = "extended")]
		Extended
	}
}
