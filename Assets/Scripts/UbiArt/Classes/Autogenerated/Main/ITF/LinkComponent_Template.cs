using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class LinkComponent_Template : ActorComponent_Template {
		[Serialize("transferEventsToChildren")] public bool transferEventsToChildren;
		[Serialize("debugColor"              )] public Color debugColor;
		[Serialize("debugColorSelected"      )] public Color debugColorSelected;
		[Serialize("debugChildIndex"         )] public int debugChildIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
			} else if (Settings.s.game == Settings.Game.RO) {
				if (!s.HasSerializerFlags(CSerializerObject.Flags.Flags0) && s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(debugColor));
					SerializeField(s, nameof(debugColorSelected));
					SerializeField(s, nameof(debugChildIndex));
				}
			} else {
				SerializeField(s, nameof(transferEventsToChildren));
			}
		}
		public override uint? ClassCRC => 0x642599B5;
	}
}

