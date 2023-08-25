using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_SimplePickable {
		public string TemplatePath { get; set; } // Can be .act or .tpl or .fcg in a frise case

		public string Name { get; set; }
		
		public Vec2d Position { get; set; }
		public Vec2d Scale { get; set; } = Vec2d.One;
		public float Z { get; set; }
		public float Angle { get; set; }
		public bool XFlip { get; set; }
	}
}
