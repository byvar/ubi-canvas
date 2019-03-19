using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class SpeedInputProviderComponent_Template : ActorComponent_Template {
		[Serialize("speedInput" )] public StringID speedInput;
		[Serialize("speedXInput")] public StringID speedXInput;
		[Serialize("speedYInput")] public StringID speedYInput;
		[Serialize("speedZInput")] public StringID speedZInput;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speedInput));
			SerializeField(s, nameof(speedXInput));
			SerializeField(s, nameof(speedYInput));
			SerializeField(s, nameof(speedZInput));
		}
		public override uint? ClassCRC => 0xA407C9A8;
	}
}

