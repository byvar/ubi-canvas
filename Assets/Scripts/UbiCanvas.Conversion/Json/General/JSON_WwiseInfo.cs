﻿using System.Collections.Generic;

namespace UbiCanvas.Conversion.Json {
	public class JSON_WwiseInfo {
		public List<JSON_WwiseEvent> Events { get; set; } = new List<JSON_WwiseEvent>();
		public List<JSON_WwiseAction> Actions { get; set; } = new List<JSON_WwiseAction>();
		public List<JSON_WwiseAttenuation> Attenuations { get; set; } = new List<JSON_WwiseAttenuation>();
	}
	public class JSON_WwiseEvent {
		public string Name { get; set; }
		public long ID { get; set; }
		public List<long> Actions { get; set; } = new List<long>();
	}
	public class JSON_WwiseAction {
		public long ID { get; set; }
		public long? ExtID { get; set; }
		public bool IsLoop { get; set; }
		public bool IsStop { get; set; }
		public long? BusID { get; set; }

		public bool KillNewest { get; set; }
		public bool IsSequence { get; set; }
		public long MaxInstances { get; set; }
		public long AvoidRepeatCount { get; set; }

		public List<JSON_WwiseSound> Sounds { get; set; } = new List<JSON_WwiseSound>();
		public JSON_Properties Properties { get; set; }
		public long? Attenuation { get; set; }
	}
	public class JSON_WwiseSound {
		public string Filename { get; set; }
	}
	public class JSON_WwiseAttenuation {
		public long ID { get; set; }
		public JSON_WwiseCurve Volume { get; set; }
		public JSON_WwiseCurve Spread { get; set; }
	}
	public class JSON_WwiseCurve {
		public List<JSON_WwiseCurvePoint> Points { get; set; } = new List<JSON_WwiseCurvePoint>();
	}
	public class JSON_WwiseCurvePoint {
		public float X { get; set; }
		public float Y { get; set; }
	}
	public class JSON_Properties {
		public List<JSON_Property> Properties { get; set; } = new List<JSON_Property>();
		public List<JSON_RangedProperty> RangedProperties { get; set; } = new List<JSON_RangedProperty>();
	}
	public class JSON_RangedProperty {
		public string Name { get; set; }
		public float Min { get; set; }
		public float Max { get; set; }
	}
	public class JSON_Property {
		public string Name { get; set; }
		public float Value { get; set; }
	}
}
