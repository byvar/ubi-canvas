using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_SimpleFriseConfig {
		public string GameMaterial { get; set; }
		public List<JSON_TextureConfig> Textures { get; set; }

		public class JSON_TextureConfig {
			public string Diffuse { get; set; }
			public string Backlight { get; set; }
		}
	}
}
