using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusAuxFactor : Event {
		public uint aux;
		public float factor;
		public StringID bus;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				bus = s.SerializeObject<StringID>(bus, name: "bus");
				aux = s.Serialize<uint>(aux, name: "aux");
				factor = s.Serialize<float>(factor, name: "factor");
			} else {
			}
		}
		public override uint? ClassCRC => 0x990E6AE9;
	}
}

