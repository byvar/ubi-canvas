using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class SpeedInputProviderComponent_Template : ActorComponent_Template {
		public StringID speedInput;
		public StringID speedXInput;
		public StringID speedYInput;
		public StringID speedZInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speedInput = s.SerializeObject<StringID>(speedInput, name: "speedInput");
			speedXInput = s.SerializeObject<StringID>(speedXInput, name: "speedXInput");
			speedYInput = s.SerializeObject<StringID>(speedYInput, name: "speedYInput");
			speedZInput = s.SerializeObject<StringID>(speedZInput, name: "speedZInput");
		}
		public override uint? ClassCRC => 0xA407C9A8;
	}
}

