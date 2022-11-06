using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ForceFieldComponent_Template : GraphicComponent_Template {
		public GFXMaterialSerializable gfxMaterial;
		public Path texture;
		public float softCollisionRadius;
		public float bounceRadius;
		public CListO<Ray_ForceFieldComponent_Template.LinkEvent> linkEvents;
		public float softCollisionExitSpeed;
		public float softCollisionExitForce;
		public StringID lockedFx;
		public float patchCenterWidth;
		public float patchCircleWidth;
		public float patchTargetWidth;
		public Angle patchCircleTangeantRotationOffset;
		public Angle patchTargetTangeantRotationOffset;
		public float patchCircleTangeantRotationFrequency;
		public float patchTargetTangeantRotationFrequency;
		public float patchTileLength;
		public float patchScrollSpeed;
		public StringID idleAnim;
		public StringID fadeAnim;
		public float tesselationLength;
		public float patchMidPointOffset;
		public float patchMidPointPercent;
		public float patchCenterOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gfxMaterial = s.SerializeObject<GFXMaterialSerializable>(gfxMaterial, name: "gfxMaterial");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
			}
			softCollisionRadius = s.Serialize<float>(softCollisionRadius, name: "softCollisionRadius");
			bounceRadius = s.Serialize<float>(bounceRadius, name: "bounceRadius");
			linkEvents = s.SerializeObject<CListO<Ray_ForceFieldComponent_Template.LinkEvent>>(linkEvents, name: "linkEvents");
			softCollisionExitSpeed = s.Serialize<float>(softCollisionExitSpeed, name: "softCollisionExitSpeed");
			softCollisionExitForce = s.Serialize<float>(softCollisionExitForce, name: "softCollisionExitForce");
			lockedFx = s.SerializeObject<StringID>(lockedFx, name: "lockedFx");
			patchCenterWidth = s.Serialize<float>(patchCenterWidth, name: "patchCenterWidth");
			patchCircleWidth = s.Serialize<float>(patchCircleWidth, name: "patchCircleWidth");
			patchTargetWidth = s.Serialize<float>(patchTargetWidth, name: "patchTargetWidth");
			patchCircleTangeantRotationOffset = s.SerializeObject<Angle>(patchCircleTangeantRotationOffset, name: "patchCircleTangeantRotationOffset");
			patchTargetTangeantRotationOffset = s.SerializeObject<Angle>(patchTargetTangeantRotationOffset, name: "patchTargetTangeantRotationOffset");
			patchCircleTangeantRotationFrequency = s.Serialize<float>(patchCircleTangeantRotationFrequency, name: "patchCircleTangeantRotationFrequency");
			patchTargetTangeantRotationFrequency = s.Serialize<float>(patchTargetTangeantRotationFrequency, name: "patchTargetTangeantRotationFrequency");
			patchTileLength = s.Serialize<float>(patchTileLength, name: "patchTileLength");
			patchScrollSpeed = s.Serialize<float>(patchScrollSpeed, name: "patchScrollSpeed");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			fadeAnim = s.SerializeObject<StringID>(fadeAnim, name: "fadeAnim");
			tesselationLength = s.Serialize<float>(tesselationLength, name: "tesselationLength");
			patchMidPointOffset = s.Serialize<float>(patchMidPointOffset, name: "patchMidPointOffset");
			patchMidPointPercent = s.Serialize<float>(patchMidPointPercent, name: "patchMidPointPercent");
			patchCenterOffset = s.Serialize<float>(patchCenterOffset, name: "patchCenterOffset");
		}
		public override uint? ClassCRC => 0x9C9C71E9;
	}
}

