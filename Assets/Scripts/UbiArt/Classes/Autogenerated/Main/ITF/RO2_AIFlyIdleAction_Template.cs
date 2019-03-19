using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIFlyIdleAction_Template : AIAction_Template {
		[Serialize("stiff")] public float stiff;
		[Serialize("damp" )] public float damp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stiff));
			SerializeField(s, nameof(damp));
		}
		public override uint? ClassCRC => 0xCD3627BC;
	}
}

