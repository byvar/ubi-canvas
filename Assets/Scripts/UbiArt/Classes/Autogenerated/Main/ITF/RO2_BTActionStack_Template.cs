using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionStack_Template : BTAction_Template {
		[Serialize("animStack"   )] public StringID animStack;
		[Serialize("animStackTop")] public StringID animStackTop;
		[Serialize("snapBoneName")] public StringID snapBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animStack));
			SerializeField(s, nameof(animStackTop));
			SerializeField(s, nameof(snapBoneName));
		}
		public override uint? ClassCRC => 0xC97C3B69;
	}
}

