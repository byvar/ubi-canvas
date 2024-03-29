namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_OldBasculePlatformComponent_Template : ActorComponent_Template {
		public float stiff = 5f;
		public float damp = 2.5f;
		public float weightToAngle = 0.05f;
		public Angle maxAngle = 0.785f;
		public float weightMultiplier = 1f;
		public float forceMultiplier = 0.005f;
		public float crushMultiplier= 100f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stiff = s.Serialize<float>(stiff, name: "stiff");
			damp = s.Serialize<float>(damp, name: "damp");
			weightToAngle = s.Serialize<float>(weightToAngle, name: "weightToAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
			forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
			crushMultiplier = s.Serialize<float>(crushMultiplier, name: "crushMultiplier");
		}
		public override uint? ClassCRC => 0x0B8BC9A1;
	}
}

