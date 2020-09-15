using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PrefetchTargetComponent : ActorComponent {
		public EditableShape ZONE;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				ZONE = s.SerializeObject<EditableShape>(ZONE, name: "ZONE");
			}
		}
		public override uint? ClassCRC => 0x9EF331FE;
	}
}

