using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_WwiseEntry {
		public string EventName { get; set; }
		public string FileName { get; set; }
		public long EventID { get; set; }
		public bool IsLoop { get; set; }
		public int? RandomIndex { get; set; }
		public long? BusID { get; set; }
	}
}
