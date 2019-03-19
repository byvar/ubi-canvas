using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataWinLevelScore : online.OpenGraphObject {
		[Serialize("score")] public uint score;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(score));
		}
		public override uint? ClassCRC => 0xC78DD6CA;
	}
}

