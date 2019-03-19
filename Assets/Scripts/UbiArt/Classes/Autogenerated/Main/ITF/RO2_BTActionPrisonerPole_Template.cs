using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionPrisonerPole_Template : BTAction_Template {
		[Serialize("animPrisoner"   )] public StringID animPrisoner;
		[Serialize("animFree"       )] public StringID animFree;
		[Serialize("animThank"      )] public StringID animThank;
		[Serialize("animFreeFall"   )] public StringID animFreeFall;
		[Serialize("countLumsReward")] public uint countLumsReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPrisoner));
			SerializeField(s, nameof(animFree));
			SerializeField(s, nameof(animThank));
			SerializeField(s, nameof(animFreeFall));
			SerializeField(s, nameof(countLumsReward));
		}
		public override uint? ClassCRC => 0x866D7FAA;
	}
}

