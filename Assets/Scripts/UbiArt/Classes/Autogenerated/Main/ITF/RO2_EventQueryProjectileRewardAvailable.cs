using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventQueryProjectileRewardAvailable : Event {
		[Serialize("rewardAvailable")] public bool rewardAvailable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rewardAvailable));
		}
		public override uint? ClassCRC => 0x6F79798E;
	}
}

