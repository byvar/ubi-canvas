namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AILumsComponent_Template : ActorComponent_Template {
		public float playerDetectorMultiplierInWater;
		public float grabAttractiveForceValue;
		public float grabMaxRepulsiveForce;
		public float grabRepulsionRadius;
		public float grabDampingFactor;
		public float timeBeforeTaken;
		public Vec2d followingOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
			} else {
				playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
				grabAttractiveForceValue = s.Serialize<float>(grabAttractiveForceValue, name: "grabAttractiveForceValue");
				grabMaxRepulsiveForce = s.Serialize<float>(grabMaxRepulsiveForce, name: "grabMaxRepulsiveForce");
				grabRepulsionRadius = s.Serialize<float>(grabRepulsionRadius, name: "grabRepulsionRadius");
				grabDampingFactor = s.Serialize<float>(grabDampingFactor, name: "grabDampingFactor");
				timeBeforeTaken = s.Serialize<float>(timeBeforeTaken, name: "timeBeforeTaken");
				followingOffset = s.SerializeObject<Vec2d>(followingOffset, name: "followingOffset");
			}
		}
		public override uint? ClassCRC => 0x781ECA51;
	}
}

