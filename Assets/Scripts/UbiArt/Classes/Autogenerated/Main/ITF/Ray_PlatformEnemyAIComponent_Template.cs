using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlatformEnemyAIComponent_Template : CSerializable {
		[Serialize("restartTweeningAfterHit")] public int restartTweeningAfterHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(restartTweeningAfterHit));
		}
		public override uint? ClassCRC => 0x83E80A8F;
	}
}

