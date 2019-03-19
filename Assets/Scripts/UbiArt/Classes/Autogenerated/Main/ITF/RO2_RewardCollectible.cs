using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardCollectible : RewardTrigger_Base {
		[Serialize("collectibleType")] public StringID collectibleType;
		[Serialize("count"          )] public uint count;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(collectibleType));
			SerializeField(s, nameof(count));
		}
		public override uint? ClassCRC => 0xB9B3904C;
	}
}

