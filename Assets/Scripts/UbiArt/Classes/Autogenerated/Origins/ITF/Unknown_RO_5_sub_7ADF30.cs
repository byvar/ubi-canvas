using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_RO_5_sub_7ADF30 : CSerializable {
		[Serialize("cheatAllPlayersTogether")] public Placeholder cheatAllPlayersTogether;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(cheatAllPlayersTogether));
			} else {
			}
		}
		public override uint? ClassCRC => 0x00000001;
	}
}

