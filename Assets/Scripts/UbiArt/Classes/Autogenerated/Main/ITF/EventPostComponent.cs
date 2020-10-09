using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventPostComponent : Event {
		public uint componentID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			componentID = s.Serialize<uint>(componentID, name: "componentID");
		}
		public override uint? ClassCRC => 0x88EACC5A;
	}
}

