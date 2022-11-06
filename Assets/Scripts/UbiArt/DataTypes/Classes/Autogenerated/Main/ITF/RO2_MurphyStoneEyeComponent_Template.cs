using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MurphyStoneEyeComponent_Template : RO2_AIComponent_Template {
		public StringID animStand;
		public StringID animHit;
		public StringID animStoneHit;
		public StringID animStoneStand;
		public Path actorStonePath;
		public float timeBeforeTrig;
		public float stoneZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animStand = s.SerializeObject<StringID>(animStand, name: "animStand");
			animHit = s.SerializeObject<StringID>(animHit, name: "animHit");
			animStoneHit = s.SerializeObject<StringID>(animStoneHit, name: "animStoneHit");
			animStoneStand = s.SerializeObject<StringID>(animStoneStand, name: "animStoneStand");
			actorStonePath = s.SerializeObject<Path>(actorStonePath, name: "actorStonePath");
			timeBeforeTrig = s.Serialize<float>(timeBeforeTrig, name: "timeBeforeTrig");
			stoneZOffset = s.Serialize<float>(stoneZOffset, name: "stoneZOffset");
		}
		public override uint? ClassCRC => 0x22A28B6B;
	}
}

