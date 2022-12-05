using System.Collections.Generic;

namespace UbiArt {
	public class ConversionSettings {
		public Settings OldSettings { get; set; }

		public List<PathConversionRule> PathConversionRules { get; set; } = new List<PathConversionRule>();
	}
}
