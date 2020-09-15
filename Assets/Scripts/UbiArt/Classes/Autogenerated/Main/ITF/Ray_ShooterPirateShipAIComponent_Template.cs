using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterPirateShipAIComponent_Template : Ray_MultiPiecesActorAIComponent_Template {
		[Serialize("bounceBallonInput"     )] public StringID bounceBallonInput;
		[Serialize("useDynamicFog"         )] public int useDynamicFog;
		[Serialize("dynamicFogDefaultColor")] public Vec3d dynamicFogDefaultColor;
		[Serialize("dynamicFogMaxDepth"    )] public float dynamicFogMaxDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bounceBallonInput));
			SerializeField(s, nameof(useDynamicFog));
			SerializeField(s, nameof(dynamicFogDefaultColor));
			SerializeField(s, nameof(dynamicFogMaxDepth));
		}
		public override uint? ClassCRC => 0xF11D2A7D;
	}
}

