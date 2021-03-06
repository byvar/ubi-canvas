using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class SaveNotificationComponent : ActorComponent {
		public CListP<uint> saveReasons;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.RM || Settings.s.game == Settings.Game.VH) {
				saveReasons = s.SerializeObject<CListP<uint>>(saveReasons, name: "saveReasons");
			}
		}
		public override uint? ClassCRC => 0xF66490C1;
	}
}

