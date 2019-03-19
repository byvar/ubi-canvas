using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataWinLevelTimeAttack : online.OpenGraphObject {
		[Serialize("minutes"     )] public uint minutes;
		[Serialize("seconds"     )] public uint seconds;
		[Serialize("milliseconds")] public uint milliseconds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minutes));
			SerializeField(s, nameof(seconds));
			SerializeField(s, nameof(milliseconds));
		}
		public override uint? ClassCRC => 0x5F71CE30;
	}
}

