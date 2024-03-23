namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PhysForceModifier_Template : CSerializable {
		public bool isRadial;
		public Vec2d force;
		public float forceVariationRange;
		public float gradientPercentage;
		public bool isInverted;
		public float centerForce;
		public float centerForceMaxSpeed;
		public float speedMultiplierX = 1f;
		public float speedMultiplierY = 1f;
		public Vec2d posOffset;
		public Angle angleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				isRadial = s.Serialize<bool>(isRadial, name: "isRadial");
				force = s.SerializeObject<Vec2d>(force, name: "force");
				gradientPercentage = s.Serialize<float>(gradientPercentage, name: "gradientPercentage");
				isInverted = s.Serialize<bool>(isInverted, name: "isInverted");
				centerForce = s.Serialize<float>(centerForce, name: "centerForce");
				centerForceMaxSpeed = s.Serialize<float>(centerForceMaxSpeed, name: "centerForceMaxSpeed");
				speedMultiplierX = s.Serialize<float>(speedMultiplierX, name: "speedMultiplierX");
				speedMultiplierY = s.Serialize<float>(speedMultiplierY, name: "speedMultiplierY");
				posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
			} else {
				isRadial = s.Serialize<bool>(isRadial, name: "isRadial");
				force = s.SerializeObject<Vec2d>(force, name: "force");
				forceVariationRange = s.Serialize<float>(forceVariationRange, name: "forceVariationRange");
				gradientPercentage = s.Serialize<float>(gradientPercentage, name: "gradientPercentage");
				isInverted = s.Serialize<bool>(isInverted, name: "isInverted");
				centerForce = s.Serialize<float>(centerForce, name: "centerForce");
				centerForceMaxSpeed = s.Serialize<float>(centerForceMaxSpeed, name: "centerForceMaxSpeed");
				speedMultiplierX = s.Serialize<float>(speedMultiplierX, name: "speedMultiplierX");
				speedMultiplierY = s.Serialize<float>(speedMultiplierY, name: "speedMultiplierY");
				posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
			}
		}
		public override uint? ClassCRC => 0x5E8F2A1D;
	}
}

