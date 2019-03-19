using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MurphyStoneEyeComponent_Template : RO2_AIComponent_Template {
		[Serialize("animStand"     )] public StringID animStand;
		[Serialize("animHit"       )] public StringID animHit;
		[Serialize("animStoneHit"  )] public StringID animStoneHit;
		[Serialize("animStoneStand")] public StringID animStoneStand;
		[Serialize("actorStonePath")] public Path actorStonePath;
		[Serialize("timeBeforeTrig")] public float timeBeforeTrig;
		[Serialize("stoneZOffset"  )] public float stoneZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animStand));
			SerializeField(s, nameof(animHit));
			SerializeField(s, nameof(animStoneHit));
			SerializeField(s, nameof(animStoneStand));
			SerializeField(s, nameof(actorStonePath));
			SerializeField(s, nameof(timeBeforeTrig));
			SerializeField(s, nameof(stoneZOffset));
		}
		public override uint? ClassCRC => 0x22A28B6B;
	}
}

