using UnityEngine;

namespace UbiArt.ITF {
	public partial class RenderParamComponent_Template : ActorComponent_Template {
		[Serialize("input"      )] public InputDesc input;
		[Serialize("inputFactor")] public InputDesc inputFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
			SerializeField(s, nameof(inputFactor));
		}
		public override uint? ClassCRC => 0xF2E7EF7F;
	}
}

