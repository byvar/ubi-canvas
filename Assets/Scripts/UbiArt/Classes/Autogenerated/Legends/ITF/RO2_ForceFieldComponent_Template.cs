using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ForceFieldComponent_Template : GraphicComponent_Template {
		[Serialize("gfxMaterial"                         )] public GFXMaterialSerializable gfxMaterial;
		[Serialize("texture"                             )] public Path texture;
		[Serialize("softCollisionRadius"                 )] public float softCollisionRadius;
		[Serialize("bounceRadius"                        )] public float bounceRadius;
		[Serialize("linkEvents"                          )] public CList<Ray_ForceFieldComponent_Template.LinkEvent> linkEvents;
		[Serialize("softCollisionExitSpeed"              )] public float softCollisionExitSpeed;
		[Serialize("softCollisionExitForce"              )] public float softCollisionExitForce;
		[Serialize("lockedFx"                            )] public StringID lockedFx;
		[Serialize("patchCenterWidth"                    )] public float patchCenterWidth;
		[Serialize("patchCircleWidth"                    )] public float patchCircleWidth;
		[Serialize("patchTargetWidth"                    )] public float patchTargetWidth;
		[Serialize("patchCircleTangeantRotationOffset"   )] public Angle patchCircleTangeantRotationOffset;
		[Serialize("patchTargetTangeantRotationOffset"   )] public Angle patchTargetTangeantRotationOffset;
		[Serialize("patchCircleTangeantRotationFrequency")] public float patchCircleTangeantRotationFrequency;
		[Serialize("patchTargetTangeantRotationFrequency")] public float patchTargetTangeantRotationFrequency;
		[Serialize("patchTileLength"                     )] public float patchTileLength;
		[Serialize("patchScrollSpeed"                    )] public float patchScrollSpeed;
		[Serialize("idleAnim"                            )] public StringID idleAnim;
		[Serialize("fadeAnim"                            )] public StringID fadeAnim;
		[Serialize("tesselationLength"                   )] public float tesselationLength;
		[Serialize("patchMidPointOffset"                 )] public float patchMidPointOffset;
		[Serialize("patchMidPointPercent"                )] public float patchMidPointPercent;
		[Serialize("patchCenterOffset"                   )] public float patchCenterOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gfxMaterial));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texture));
			}
			SerializeField(s, nameof(softCollisionRadius));
			SerializeField(s, nameof(bounceRadius));
			SerializeField(s, nameof(linkEvents));
			SerializeField(s, nameof(softCollisionExitSpeed));
			SerializeField(s, nameof(softCollisionExitForce));
			SerializeField(s, nameof(lockedFx));
			SerializeField(s, nameof(patchCenterWidth));
			SerializeField(s, nameof(patchCircleWidth));
			SerializeField(s, nameof(patchTargetWidth));
			SerializeField(s, nameof(patchCircleTangeantRotationOffset));
			SerializeField(s, nameof(patchTargetTangeantRotationOffset));
			SerializeField(s, nameof(patchCircleTangeantRotationFrequency));
			SerializeField(s, nameof(patchTargetTangeantRotationFrequency));
			SerializeField(s, nameof(patchTileLength));
			SerializeField(s, nameof(patchScrollSpeed));
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(fadeAnim));
			SerializeField(s, nameof(tesselationLength));
			SerializeField(s, nameof(patchMidPointOffset));
			SerializeField(s, nameof(patchMidPointPercent));
			SerializeField(s, nameof(patchCenterOffset));
		}
		public override uint? ClassCRC => 0x9C9C71E9;
	}
}

