using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionPrisonerPole_Template : BTAction_Template {
		public StringID animPrisoner;
		public StringID animFree;
		public StringID animThank;
		public StringID animFreeFall;
		public uint countLumsReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPrisoner = s.SerializeObject<StringID>(animPrisoner, name: "animPrisoner");
			animFree = s.SerializeObject<StringID>(animFree, name: "animFree");
			animThank = s.SerializeObject<StringID>(animThank, name: "animThank");
			animFreeFall = s.SerializeObject<StringID>(animFreeFall, name: "animFreeFall");
			countLumsReward = s.Serialize<uint>(countLumsReward, name: "countLumsReward");
		}
		public override uint? ClassCRC => 0x866D7FAA;
	}
}

