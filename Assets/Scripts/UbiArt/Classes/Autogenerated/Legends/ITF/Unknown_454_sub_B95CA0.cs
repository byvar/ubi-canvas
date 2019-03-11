using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_454_sub_B95CA0 : CSerializable {
		[Serialize("minStunTime"        )] public float minStunTime;
		[Serialize("maxStunTime"        )] public float maxStunTime;
		[Serialize("loopingAnimDuration")] public float loopingAnimDuration;
		[Serialize("stunAnimation"      )] public StringID stunAnimation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minStunTime));
			SerializeField(s, nameof(maxStunTime));
			SerializeField(s, nameof(loopingAnimDuration));
			SerializeField(s, nameof(stunAnimation));
		}
		public override uint? ClassCRC => 0x37B79389;
	}
}

