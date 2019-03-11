using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ScaleTunnelComponent_Template : CSerializable {
		[Serialize("area" )] public Placeholder area;
		[Serialize("scale")] public float scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(area));
			SerializeField(s, nameof(scale));
		}
		public override uint? ClassCRC => 0x1A08EAF7;
	}
}

