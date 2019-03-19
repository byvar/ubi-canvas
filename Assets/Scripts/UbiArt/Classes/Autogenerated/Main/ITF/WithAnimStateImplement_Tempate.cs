using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class WithAnimStateImplement_Tempate : WithAnimState_Template {
		[Serialize("implementTempate")] public StateImplement_Template implementTempate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(implementTempate));
			}
		}
		public override uint? ClassCRC => 0x29C931C9;
	}
}

