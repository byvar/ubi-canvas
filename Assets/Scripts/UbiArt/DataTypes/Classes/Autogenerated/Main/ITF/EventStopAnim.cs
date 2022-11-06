using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventStopAnim : Event {
		public StringID AnimToStop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AnimToStop = s.SerializeObject<StringID>(AnimToStop, name: "AnimToStop");
		}
		public override uint? ClassCRC => 0x58E72E54;
	}
}

