using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_427_sub_B89BF0 : CSerializable {
		[Serialize("idleBehavior"             )] public Placeholder idleBehavior;
		[Serialize("receiveHitBehavior"       )] public Placeholder receiveHitBehavior;
		[Serialize("deathBehavior"            )] public Placeholder deathBehavior;
		[Serialize("tickleBehavior"           )] public Placeholder tickleBehavior;
		[Serialize("cameraRelative"           )] public bool cameraRelative;
		[Serialize("triggerable"              )] public bool triggerable;
		[Serialize("dynamicFlip"              )] public bool dynamicFlip;
		[Serialize("dynamicFlipStartLeft"     )] public bool dynamicFlipStartLeft;
		[Serialize("useFixedAngle"            )] public bool useFixedAngle;
		[Serialize("fixedAngle"               )] public Angle fixedAngle;
		[Serialize("takeMoveOrientation"      )] public bool takeMoveOrientation;
		[Serialize("takeMoveOrientationOffset")] public Angle takeMoveOrientationOffset;
		[Serialize("useDynamicFog"            )] public bool useDynamicFog;
		[Serialize("dynamicFogDefaultColor"   )] public Vector3 dynamicFogDefaultColor;
		[Serialize("dynamicFogMaxDepth"       )] public float dynamicFogMaxDepth;
		[Serialize("canBeCrushed"             )] public bool canBeCrushed;
		[Serialize("disableOnBecomeInactive"  )] public bool disableOnBecomeInactive;
		[Serialize("visualScaleMultiplier"    )] public float visualScaleMultiplier;
		[Serialize("DRCplayRate"              )] public float DRCplayRate;
		[Serialize("havespawner"              )] public bool havespawner;
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

