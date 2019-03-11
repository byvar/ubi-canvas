using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenRenderComponent_Template : GraphicComponent_Template {
		[Serialize("trail")] public Trail_Template trail;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(trail));
		}
		public override uint? ClassCRC => 0x117F0373;
	}
}

