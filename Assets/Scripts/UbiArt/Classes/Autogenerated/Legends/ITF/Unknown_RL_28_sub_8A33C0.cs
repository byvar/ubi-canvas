using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_28_sub_8A33C0 : CSerializable {
		public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				sender = s.Serialize<uint>(sender, name: "sender");
			} else {
			}
		}
		public override uint? ClassCRC => 0x5375ABEE;
	}
}

