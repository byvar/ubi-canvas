using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataTreeLevelUp : online.OpenGraphObject {
		public uint level;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			level = s.Serialize<uint>(level, name: "level");
		}
		public override uint? ClassCRC => 0xF80710E8;
	}
}

