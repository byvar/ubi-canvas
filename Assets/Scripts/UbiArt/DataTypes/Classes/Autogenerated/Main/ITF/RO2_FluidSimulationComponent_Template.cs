namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_FluidSimulationComponent_Template : RO2_SoftCollisionComponent_Template {
		public StringID FX;
		public StringID SpawnSound;
		public StringID SwarmSound;
		public StringID CaughtSound;
		public StringID ReleaseSound;
		public float InputMaxSpeed;
		public float RadiusMin;
		public float RadiusMax;
		public bool DrawObstacles;
		public bool DrawPlayers;
		public bool DrawCircles;
		public GFXMaterialSerializable FluidMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			FX = s.SerializeObject<StringID>(FX, name: "FX");
			SpawnSound = s.SerializeObject<StringID>(SpawnSound, name: "SpawnSound");
			SwarmSound = s.SerializeObject<StringID>(SwarmSound, name: "SwarmSound");
			CaughtSound = s.SerializeObject<StringID>(CaughtSound, name: "CaughtSound");
			ReleaseSound = s.SerializeObject<StringID>(ReleaseSound, name: "ReleaseSound");
			InputMaxSpeed = s.Serialize<float>(InputMaxSpeed, name: "InputMaxSpeed");
			RadiusMin = s.Serialize<float>(RadiusMin, name: "RadiusMin");
			RadiusMax = s.Serialize<float>(RadiusMax, name: "RadiusMax");
			DrawObstacles = s.Serialize<bool>(DrawObstacles, name: "DrawObstacles");
			DrawPlayers = s.Serialize<bool>(DrawPlayers, name: "DrawPlayers");
			DrawCircles = s.Serialize<bool>(DrawCircles, name: "DrawCircles");
			FluidMaterial = s.SerializeObject<GFXMaterialSerializable>(FluidMaterial, name: "FluidMaterial");
		}
		public override uint? ClassCRC => 0x6F917056;
	}
}

