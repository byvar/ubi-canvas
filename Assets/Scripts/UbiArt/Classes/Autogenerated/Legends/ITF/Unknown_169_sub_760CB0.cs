using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_169_sub_760CB0 : CSerializable {
		[Serialize("inputAnimLeft"  )] public StringID inputAnimLeft;
		[Serialize("inputAnimRight" )] public StringID inputAnimRight;
		[Serialize("inputStateLeft" )] public StringID inputStateLeft;
		[Serialize("inputStateRight")] public StringID inputStateRight;
		[Serialize("animTimeOpen"   )] public float animTimeOpen;
		[Serialize("animTimeClose"  )] public float animTimeClose;
		[Serialize("allowCutAnim"   )] public bool allowCutAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputAnimLeft));
			SerializeField(s, nameof(inputAnimRight));
			SerializeField(s, nameof(inputStateLeft));
			SerializeField(s, nameof(inputStateRight));
			SerializeField(s, nameof(animTimeOpen));
			SerializeField(s, nameof(animTimeClose));
			SerializeField(s, nameof(allowCutAnim));
		}
		public override uint? ClassCRC => 0xDE34F7E8;
	}
}

