using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DanceDoorComponent_Template : CSerializable {
		public StringID animClosed;
		public StringID animClosedWithMusic;
		public StringID animOpening;
		public float danceTime;
		public float warmupTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animClosed = s.SerializeObject<StringID>(animClosed, name: "animClosed");
			animClosedWithMusic = s.SerializeObject<StringID>(animClosedWithMusic, name: "animClosedWithMusic");
			animOpening = s.SerializeObject<StringID>(animOpening, name: "animOpening");
			danceTime = s.Serialize<float>(danceTime, name: "danceTime");
			warmupTime = s.Serialize<float>(warmupTime, name: "warmupTime");
		}
		public override uint? ClassCRC => 0x7E2B72A9;
	}
}

