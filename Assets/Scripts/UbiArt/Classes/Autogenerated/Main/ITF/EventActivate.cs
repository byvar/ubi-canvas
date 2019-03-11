using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventActivate : Event {
		[Serialize("activated")] public bool activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(activated));
			} else {
			}
		}
		public override uint? ClassCRC => 0x9D550A44;
	}
}

