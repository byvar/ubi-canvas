using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ElectoonSpawnerComponent_Template : CSerializable {
		public Path path;
		public float maxTangeantLength;
		public float minTangeantLength;
		public float tangeantSpeedMax;
		public float tangeantSpeedMin;
		public float electoonSpeed;
		public float electoonAcceleration;
		public float targetSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			path = s.SerializeObject<Path>(path, name: "path");
			maxTangeantLength = s.Serialize<float>(maxTangeantLength, name: "maxTangeantLength");
			minTangeantLength = s.Serialize<float>(minTangeantLength, name: "minTangeantLength");
			tangeantSpeedMax = s.Serialize<float>(tangeantSpeedMax, name: "tangeantSpeedMax");
			tangeantSpeedMin = s.Serialize<float>(tangeantSpeedMin, name: "tangeantSpeedMin");
			electoonSpeed = s.Serialize<float>(electoonSpeed, name: "electoonSpeed");
			electoonAcceleration = s.Serialize<float>(electoonAcceleration, name: "electoonAcceleration");
			targetSmooth = s.Serialize<float>(targetSmooth, name: "targetSmooth");
		}
		public override uint? ClassCRC => 0x76A63BFB;
	}
}

