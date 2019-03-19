using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DanceDoorComponent_Template : CSerializable {
		[Serialize("animClosed"         )] public StringID animClosed;
		[Serialize("animClosedWithMusic")] public StringID animClosedWithMusic;
		[Serialize("animOpening"        )] public StringID animOpening;
		[Serialize("danceTime"          )] public float danceTime;
		[Serialize("warmupTime"         )] public float warmupTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animClosed));
			SerializeField(s, nameof(animClosedWithMusic));
			SerializeField(s, nameof(animOpening));
			SerializeField(s, nameof(danceTime));
			SerializeField(s, nameof(warmupTime));
		}
		public override uint? ClassCRC => 0x7E2B72A9;
	}
}

