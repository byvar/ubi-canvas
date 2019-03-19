using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AFXPostProcessComponent_Template : ActorComponent_Template {
		[Serialize("input"         )] public InputDesc input;
		[Serialize("inputFactor"   )] public InputDesc inputFactor;
		[Serialize("customTexOldTV")] public Path customTexOldTV;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
			SerializeField(s, nameof(inputFactor));
			SerializeField(s, nameof(customTexOldTV));
		}
		public override uint? ClassCRC => 0xDBC40194;
	}
}

