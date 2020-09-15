using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardCollectible : RewardTrigger_Base {
		public StringID collectibleType;
		public uint count;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			collectibleType = s.SerializeObject<StringID>(collectibleType, name: "collectibleType");
			count = s.Serialize<uint>(count, name: "count");
		}
		public override uint? ClassCRC => 0xB9B3904C;
	}
}

