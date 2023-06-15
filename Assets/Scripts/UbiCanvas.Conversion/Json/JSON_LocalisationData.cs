using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_LocalisationData {
		public uint ID { get; set; }
		public Dictionary<string, string> Text { get; set; }
	}
}
