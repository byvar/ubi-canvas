using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class TODOComponent_Template : ActorComponent_Template {
		public Path textPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				textPath = s.SerializeObject<Path>(textPath, name: "textPath");
			} else {
			}
		}
		public override uint? ClassCRC => 0x3C0BDF51;
	}
}

