using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScaleTunnelComponent_Template : ActorComponent_Template {
		[Serialize("area" )] public PhysShapeBox area;
		[Serialize("scale")] public float scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(area));
			SerializeField(s, nameof(scale));
		}
		public override uint? ClassCRC => 0x92013AE2;
	}
}

