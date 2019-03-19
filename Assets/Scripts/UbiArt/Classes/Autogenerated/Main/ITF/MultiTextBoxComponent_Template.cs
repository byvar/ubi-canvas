using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class MultiTextBoxComponent_Template : ActorComponent_Template {
		[Serialize("styles")] public CList<FontTextArea.Style> styles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(styles));
			}
		}
		public override uint? ClassCRC => 0x732EAD76;
	}
}

