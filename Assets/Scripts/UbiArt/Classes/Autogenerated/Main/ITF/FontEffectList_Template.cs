using UnityEngine;

namespace UbiArt.ITF {
	public partial class FontEffectList_Template : TemplateObj {
		[Serialize("effects")] public CList<FontEffect_Template> effects;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(effects));
		}
		public override uint? ClassCRC => 0x5261948B;
	}
}

