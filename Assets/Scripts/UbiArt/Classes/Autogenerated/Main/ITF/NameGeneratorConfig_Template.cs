using UnityEngine;

namespace UbiArt.ITF {
	public partial class NameGeneratorConfig_Template : TemplateObj {
		[Serialize("ColorProbability")] public float ColorProbability;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ColorProbability));
		}
		public override uint? ClassCRC => 0xB051357D;
	}
}

