using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSequenceActorActivate : Event {
		public bool activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activate = s.Serialize<bool>(activate, name: "activate");
		}
		public override uint? ClassCRC => 0x42BB4EF3;
	}
}

