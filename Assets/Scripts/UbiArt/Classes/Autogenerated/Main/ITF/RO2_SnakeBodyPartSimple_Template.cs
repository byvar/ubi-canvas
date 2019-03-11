using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SnakeBodyPartSimple_Template : RO2_SnakeBodyPart_Template {
		[Serialize("renderer")] public Generic<RO2_SnakeBodyPartRenderer_Template> renderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(renderer));
		}
		public override uint? ClassCRC => 0x0E3424CC;
	}
}

