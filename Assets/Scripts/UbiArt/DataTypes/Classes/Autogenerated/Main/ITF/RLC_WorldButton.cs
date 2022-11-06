using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_WorldButton : CSerializable {
		public Placeholder eventSentWhenSpawned;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eventSentWhenSpawned = s.SerializeObject<Placeholder>(eventSentWhenSpawned, name: "eventSentWhenSpawned");
		}
		public override uint? ClassCRC => 0x90CDAC93;
	}
}

