using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlatformEnemyAIComponent_Template : CSerializable {
		public int restartTweeningAfterHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			restartTweeningAfterHit = s.Serialize<int>(restartTweeningAfterHit, name: "restartTweeningAfterHit");
		}
		public override uint? ClassCRC => 0x83E80A8F;
	}
}

