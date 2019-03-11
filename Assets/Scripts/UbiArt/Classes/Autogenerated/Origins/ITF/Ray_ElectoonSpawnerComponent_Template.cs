using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ElectoonSpawnerComponent_Template : CSerializable {
		[Serialize("path"                )] public Path path;
		[Serialize("maxTangeantLength"   )] public float maxTangeantLength;
		[Serialize("minTangeantLength"   )] public float minTangeantLength;
		[Serialize("tangeantSpeedMax"    )] public float tangeantSpeedMax;
		[Serialize("tangeantSpeedMin"    )] public float tangeantSpeedMin;
		[Serialize("electoonSpeed"       )] public float electoonSpeed;
		[Serialize("electoonAcceleration")] public float electoonAcceleration;
		[Serialize("targetSmooth"        )] public float targetSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(path));
			SerializeField(s, nameof(maxTangeantLength));
			SerializeField(s, nameof(minTangeantLength));
			SerializeField(s, nameof(tangeantSpeedMax));
			SerializeField(s, nameof(tangeantSpeedMin));
			SerializeField(s, nameof(electoonSpeed));
			SerializeField(s, nameof(electoonAcceleration));
			SerializeField(s, nameof(targetSmooth));
		}
		public override uint? ClassCRC => 0x76A63BFB;
	}
}

