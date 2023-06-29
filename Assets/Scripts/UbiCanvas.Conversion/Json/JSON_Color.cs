using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_Color { 
		public float b { get; set; }
		public float g { get; set; }
		public float r { get; set; }
		public float a { get; set; }

		[JsonExtensionData]
		private IDictionary<string, JToken> _additionalData;

		public JSON_Color() {
			_additionalData = new Dictionary<string, JToken>();
		}
		public JSON_Color(UbiArt.Color c) : this() {
			_additionalData = new Dictionary<string, JToken>();
			r = c.r;
			g = c.g;
			b = c.b;
			a = c.a;
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext context) {
			// HTML is not deserialized to any property, and so it is added to the extension data dictionary
			if (_additionalData.ContainsKey("HTML")) {
				string colorcode = (string)_additionalData["HTML"];
				if (!string.IsNullOrEmpty(colorcode)) {
					colorcode = colorcode.TrimStart('#');

					if (colorcode.Length == 6) {
						r = int.Parse(colorcode.Substring(0, 2), NumberStyles.HexNumber) / 255f;
						g = int.Parse(colorcode.Substring(2, 2), NumberStyles.HexNumber) / 255f;
						b = int.Parse(colorcode.Substring(4, 2), NumberStyles.HexNumber) / 255f;
						a = 1f;
					} else { // assuming length of 8
						r = int.Parse(colorcode.Substring(0, 2), NumberStyles.HexNumber) / 255f;
						g = int.Parse(colorcode.Substring(2, 2), NumberStyles.HexNumber) / 255f;
						b = int.Parse(colorcode.Substring(4, 2), NumberStyles.HexNumber) / 255f;
						a = int.Parse(colorcode.Substring(6, 2), NumberStyles.HexNumber) / 255f;
					}
				}
			}
		}

		[JsonIgnore]
		public UbiArt.Color Color => new Color(r,g,b,a);

		public static JSON_Color FromColor(Color c) {
			if(c == null) return null;
			return new JSON_Color(c);
		}

		public static implicit operator JSON_Color(Color c) => FromColor(c);
		public static implicit operator Color(JSON_Color c) => c?.Color;
	}
}
