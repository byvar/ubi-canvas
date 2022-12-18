namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterAIComponent_Template : RO2_AIComponent_Template {
		public Generic<TemplateAIBehavior> idleBehavior;
		public Generic<TemplateAIBehavior> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public Generic<TemplateAIBehavior> tickleBehavior;
		public int cameraRelative;
		public int triggerable;
		public int dynamicFlip;
		public int dynamicFlipStartLeft;
		public int useFixedAngle;
		public Angle fixedAngle;
		public int takeMoveOrientation;
		public Angle takeMoveOrientationOffset;
		public int useDynamicFog;
		public Vec3d dynamicFogDefaultColor;
		public float dynamicFogMaxDepth;
		public int canBeCrushed;
		public int disableOnBecomeInactive;
		public float visualScaleMultiplier;
		public float DRCplayRate;
		public int havespawner;
		public float laughingTime;
		public StringID laughAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(idleBehavior, name: "idleBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			tickleBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(tickleBehavior, name: "tickleBehavior");
			cameraRelative = s.Serialize<int>(cameraRelative, name: "cameraRelative");
			triggerable = s.Serialize<int>(triggerable, name: "triggerable");
			dynamicFlip = s.Serialize<int>(dynamicFlip, name: "dynamicFlip");
			dynamicFlipStartLeft = s.Serialize<int>(dynamicFlipStartLeft, name: "dynamicFlipStartLeft");
			useFixedAngle = s.Serialize<int>(useFixedAngle, name: "useFixedAngle");
			fixedAngle = s.SerializeObject<Angle>(fixedAngle, name: "fixedAngle");
			takeMoveOrientation = s.Serialize<int>(takeMoveOrientation, name: "takeMoveOrientation");
			takeMoveOrientationOffset = s.SerializeObject<Angle>(takeMoveOrientationOffset, name: "takeMoveOrientationOffset");
			useDynamicFog = s.Serialize<int>(useDynamicFog, name: "useDynamicFog");
			dynamicFogDefaultColor = s.SerializeObject<Vec3d>(dynamicFogDefaultColor, name: "dynamicFogDefaultColor");
			dynamicFogMaxDepth = s.Serialize<float>(dynamicFogMaxDepth, name: "dynamicFogMaxDepth");
			canBeCrushed = s.Serialize<int>(canBeCrushed, name: "canBeCrushed");
			disableOnBecomeInactive = s.Serialize<int>(disableOnBecomeInactive, name: "disableOnBecomeInactive");
			visualScaleMultiplier = s.Serialize<float>(visualScaleMultiplier, name: "visualScaleMultiplier");
			DRCplayRate = s.Serialize<float>(DRCplayRate, name: "DRCplayRate");
			havespawner = s.Serialize<int>(havespawner, name: "havespawner");
			laughingTime = s.Serialize<float>(laughingTime, name: "laughingTime");
			laughAnim = s.SerializeObject<StringID>(laughAnim, name: "laughAnim");
		}
		public override uint? ClassCRC => 0x576531AB;
	}
}

