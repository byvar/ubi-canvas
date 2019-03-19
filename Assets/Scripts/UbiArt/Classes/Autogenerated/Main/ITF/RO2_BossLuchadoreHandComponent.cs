using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossLuchadoreHandComponent : GraphicComponent {
		[Serialize("hitShape")] public Generic<PhysShape> hitShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hitShape));
		}
		public override uint? ClassCRC => 0xF9A91B67;
	}
}

