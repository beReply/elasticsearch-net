using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Ilm.Apis
{
	public class GetStatusPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("ilm/apis/get-status.asciidoc:44")]
		public void Line44()
		{
			// tag::182df084f028479ecbe8d7648ddad892[]
			var response0 = new SearchResponse<object>();
			// end::182df084f028479ecbe8d7648ddad892[]

			response0.MatchesExample(@"GET _ilm/status");
		}
	}
}