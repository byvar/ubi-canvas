using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventHidePlayers : Event {
		[Serialize("hideMainCharacter")] public bool hideMainCharacter;
		[Serialize("hideSideKick"     )] public bool hideSideKick;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hideMainCharacter));
			SerializeField(s, nameof(hideSideKick));
		}
		public override uint? ClassCRC => 0x831992D8;
	}
}

