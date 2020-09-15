using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataWinLevelScore : online.OpenGraphObject {
		public uint score;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			score = s.Serialize<uint>(score, name: "score");
		}
		public override uint? ClassCRC => 0xC78DD6CA;
	}
}

