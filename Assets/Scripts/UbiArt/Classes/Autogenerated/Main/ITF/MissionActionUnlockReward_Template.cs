using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionUnlockReward_Template : CSerializable {
		[Serialize("rewardID")] public StringID rewardID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rewardID));
		}
		public override uint? ClassCRC => 0x46A4C1B5;
	}
}

