using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_LTReward : CSerializable {
		[Serialize("id"        )] public uint id;
		[Serialize("rewardType")] public uint rewardType;
		[Serialize("permut"    )] public uint permut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(rewardType));
			SerializeField(s, nameof(permut));
		}
	}
}

