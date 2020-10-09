using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_DynamicFogComponent : ActorComponent {
		public int useTempateFogParams;
		public Color dynamicFogColor;
		public float dynamicFogMaxDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				useTempateFogParams = s.Serialize<int>(useTempateFogParams, name: "useTempateFogParams");
				dynamicFogColor = s.SerializeObject<Color>(dynamicFogColor, name: "dynamicFogColor");
				dynamicFogMaxDepth = s.Serialize<float>(dynamicFogMaxDepth, name: "dynamicFogMaxDepth");
			}
		}
		public override uint? ClassCRC => 0x3104D334;
	}
}

