using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL | GameFlags.COL | GameFlags.COL | GameFlags.COL | GameFlags.COL)]
	public partial class Unknown_RL_221_sub_82A9C0 : CSerializable {
		[Serialize("cheatAllPlayersTogether")] public Placeholder cheatAllPlayersTogether;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(cheatAllPlayersTogether));
			}
		}
		public override uint? ClassCRC => 0x00000001;
	}
}

