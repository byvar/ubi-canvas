using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventHidePlayers : Event {
		public bool hideMainCharacter;
		public bool hideSideKick;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hideMainCharacter = s.Serialize<bool>(hideMainCharacter, name: "hideMainCharacter");
			hideSideKick = s.Serialize<bool>(hideSideKick, name: "hideSideKick");
		}
		public override uint? ClassCRC => 0x831992D8;
	}
}

