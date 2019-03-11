using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_DynamicFogComponent_Template : CSerializable {
		[Serialize("useDynamicFog"         )] public bool useDynamicFog;
		[Serialize("dynamicFogDefaultColor")] public Color dynamicFogDefaultColor;
		[Serialize("dynamicFogMaxDepth"    )] public float dynamicFogMaxDepth;
		[Serialize("isDataOnly"            )] public bool isDataOnly;
		[Serialize("isModifier"            )] public bool isModifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useDynamicFog));
			SerializeField(s, nameof(dynamicFogDefaultColor));
			SerializeField(s, nameof(dynamicFogMaxDepth));
			SerializeField(s, nameof(isDataOnly));
			SerializeField(s, nameof(isModifier));
		}
		public override uint? ClassCRC => 0x7C8B6190;
	}
}

