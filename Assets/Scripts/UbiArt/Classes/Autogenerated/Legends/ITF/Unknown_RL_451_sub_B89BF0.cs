using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_451_sub_B89BF0 : RO2_AIComponent_Template {
		[Serialize("idleBehavior"             )] public Generic<TemplateAIBehavior> idleBehavior;
		[Serialize("receiveHitBehavior"       )] public Generic<TemplateAIBehavior> receiveHitBehavior;
		[Serialize("deathBehavior"            )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("tickleBehavior"           )] public Generic<TemplateAIBehavior> tickleBehavior;
		[Serialize("cameraRelative"           )] public int cameraRelative;
		[Serialize("triggerable"              )] public int triggerable;
		[Serialize("dynamicFlip"              )] public int dynamicFlip;
		[Serialize("dynamicFlipStartLeft"     )] public int dynamicFlipStartLeft;
		[Serialize("useFixedAngle"            )] public int useFixedAngle;
		[Serialize("fixedAngle"               )] public Angle fixedAngle;
		[Serialize("takeMoveOrientation"      )] public int takeMoveOrientation;
		[Serialize("takeMoveOrientationOffset")] public Angle takeMoveOrientationOffset;
		[Serialize("useDynamicFog"            )] public int useDynamicFog;
		[Serialize("dynamicFogDefaultColor"   )] public Vector3 dynamicFogDefaultColor;
		[Serialize("dynamicFogMaxDepth"       )] public float dynamicFogMaxDepth;
		[Serialize("canBeCrushed"             )] public int canBeCrushed;
		[Serialize("disableOnBecomeInactive"  )] public int disableOnBecomeInactive;
		[Serialize("visualScaleMultiplier"    )] public float visualScaleMultiplier;
		[Serialize("DRCplayRate"              )] public float DRCplayRate;
		[Serialize("havespawner"              )] public int havespawner;
		[Serialize("laughingTime"             )] public float laughingTime;
		[Serialize("laughAnim"                )] public StringID laughAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(tickleBehavior));
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
			SerializeField(s, nameof(DRCplayRate));
			SerializeField(s, nameof(havespawner));
			SerializeField(s, nameof(laughingTime));
			SerializeField(s, nameof(laughAnim));
		}
		public override uint? ClassCRC => 0x576531AB;
	}
}

