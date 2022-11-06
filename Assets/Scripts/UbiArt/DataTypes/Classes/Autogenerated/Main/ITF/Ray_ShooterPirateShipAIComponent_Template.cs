using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_ShooterPirateShipAIComponent_Template : Ray_MultiPiecesActorAIComponent_Template {
		public StringID bounceBallonInput;
		public int useDynamicFog;
		public Vec3d dynamicFogDefaultColor;
		public float dynamicFogMaxDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bounceBallonInput = s.SerializeObject<StringID>(bounceBallonInput, name: "bounceBallonInput");
			useDynamicFog = s.Serialize<int>(useDynamicFog, name: "useDynamicFog");
			dynamicFogDefaultColor = s.SerializeObject<Vec3d>(dynamicFogDefaultColor, name: "dynamicFogDefaultColor");
			dynamicFogMaxDepth = s.Serialize<float>(dynamicFogMaxDepth, name: "dynamicFogMaxDepth");
		}
		public override uint? ClassCRC => 0xF11D2A7D;
	}
}

