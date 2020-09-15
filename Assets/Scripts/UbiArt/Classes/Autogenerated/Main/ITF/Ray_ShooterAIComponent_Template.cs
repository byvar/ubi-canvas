using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("idleBehavior"             )] public Generic<TemplateAIBehavior> idleBehavior;
		[Serialize("receiveHitBehavior"       )] public Generic<Ray_AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"            )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("cameraRelative"           )] public int cameraRelative;
		[Serialize("triggerable"              )] public int triggerable;
		[Serialize("dynamicFlip"              )] public int dynamicFlip;
		[Serialize("dynamicFlipStartLeft"     )] public int dynamicFlipStartLeft;
		[Serialize("useFixedAngle"            )] public int useFixedAngle;
		[Serialize("fixedAngle"               )] public Angle fixedAngle;
		[Serialize("takeMoveOrientation"      )] public int takeMoveOrientation;
		[Serialize("takeMoveOrientationOffset")] public Angle takeMoveOrientationOffset;
		[Serialize("useDynamicFog"            )] public int useDynamicFog;
		[Serialize("dynamicFogDefaultColor"   )] public Vec3d dynamicFogDefaultColor;
		[Serialize("dynamicFogMaxDepth"       )] public float dynamicFogMaxDepth;
		[Serialize("canBeCrushed"             )] public int canBeCrushed;
		[Serialize("disableOnBecomeInactive"  )] public int disableOnBecomeInactive;
		[Serialize("visualScaleMultiplier"    )] public float visualScaleMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(cameraRelative));
			SerializeField(s, nameof(triggerable));
			SerializeField(s, nameof(dynamicFlip));
			SerializeField(s, nameof(dynamicFlipStartLeft));
			SerializeField(s, nameof(useFixedAngle));
			SerializeField(s, nameof(fixedAngle));
			SerializeField(s, nameof(takeMoveOrientation));
			SerializeField(s, nameof(takeMoveOrientationOffset));
			SerializeField(s, nameof(useDynamicFog));
			SerializeField(s, nameof(dynamicFogDefaultColor));
			SerializeField(s, nameof(dynamicFogMaxDepth));
			SerializeField(s, nameof(canBeCrushed));
			SerializeField(s, nameof(disableOnBecomeInactive));
			SerializeField(s, nameof(visualScaleMultiplier));
		}
		public override uint? ClassCRC => 0xF13379AE;
	}
}

