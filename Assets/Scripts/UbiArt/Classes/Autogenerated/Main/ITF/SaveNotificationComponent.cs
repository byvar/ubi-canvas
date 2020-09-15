using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class SaveNotificationComponent : ActorComponent {
		public CList<uint> saveReasons;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.VH) {
				saveReasons = s.SerializeObject<CList<uint>>(saveReasons, name: "saveReasons");
			}
		}
		public override uint? ClassCRC => 0xF66490C1;
	}
}

