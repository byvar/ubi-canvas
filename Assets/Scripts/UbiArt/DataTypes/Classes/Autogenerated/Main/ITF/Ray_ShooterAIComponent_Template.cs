namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ShooterAIComponent_Template : Ray_AIComponent_Template {
		public Generic<TemplateAIBehavior> idleBehavior;
		public Generic<Ray_AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
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
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(idleBehavior, name: "idleBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<Ray_AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
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
		}
		public override uint? ClassCRC => 0xF13379AE;
	}
}

