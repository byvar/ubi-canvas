using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PadRumbleManager_Template : TemplateObj {
		[Serialize("rumbles")] public CList<PadRumble> rumbles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(rumbles));
			}
		}
		public override uint? ClassCRC => 0xCBC543B4;
	}
}

