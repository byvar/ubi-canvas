using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataTreeLevelUp : online.OpenGraphObject {
		[Serialize("level")] public uint level;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(level));
		}
		public override uint? ClassCRC => 0xF80710E8;
	}
}

