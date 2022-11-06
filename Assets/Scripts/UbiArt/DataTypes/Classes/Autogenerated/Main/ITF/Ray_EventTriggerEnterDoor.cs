using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventTriggerEnterDoor : Event {
		public uint destination;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			destination = s.Serialize<uint>(destination, name: "destination");
		}
		public override uint? ClassCRC => 0x32A700B6;
	}
}

