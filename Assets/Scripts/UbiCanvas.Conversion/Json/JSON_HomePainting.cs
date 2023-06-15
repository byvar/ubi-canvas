using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_HomePainting { // PackageDescriptor in home.isc
		public string ID { get; set; } // Same as WorldID
		public int Priority { get; set; }
		public string DecorationBrickPath { get; set; }
		public string MapPath { get; set; } // Path to an isc. Fill this in if painting leads to a map
		public string HubPath { get; set; } // Path to an isc. Fill this in if painting leads to a hub

		public JSON_LockData Lock { get; set; }
	}
}
