using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TweenTeleport : TweenInstruction {
		[Serialize("name")] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
			} else {
			}
		}
		public override uint? ClassCRC => 0x0E51C181;
	}
}

