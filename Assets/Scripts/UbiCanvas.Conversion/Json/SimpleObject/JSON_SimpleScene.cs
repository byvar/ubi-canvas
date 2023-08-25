using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_SimpleScene {
		public List<JSON_SimplePickable> Actor { get; set; }
		public List<JSON_SimpleFrise> Frise { get; set; }
	}
}
