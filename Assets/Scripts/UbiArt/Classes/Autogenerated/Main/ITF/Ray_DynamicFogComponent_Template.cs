using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_DynamicFogComponent_Template : CSerializable {
		[Serialize("useDynamicFog"         )] public int useDynamicFog;
		[Serialize("dynamicFogDefaultColor")] public Color dynamicFogDefaultColor;
		[Serialize("dynamicFogMaxDepth"    )] public float dynamicFogMaxDepth;
		[Serialize("isDataOnly"            )] public int isDataOnly;
		[Serialize("isModifier"            )] public int isModifier;
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

