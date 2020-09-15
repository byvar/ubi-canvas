using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataWinLevelTimeAttack : online.OpenGraphObject {
		public uint minutes;
		public uint seconds;
		public uint milliseconds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minutes = s.Serialize<uint>(minutes, name: "minutes");
			seconds = s.Serialize<uint>(seconds, name: "seconds");
			milliseconds = s.Serialize<uint>(milliseconds, name: "milliseconds");
		}
		public override uint? ClassCRC => 0x5F71CE30;
	}
}

