namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ChallengeFireWallComponent_Template : ActorComponent_Template {
		public uint faction;
		public Generic<PhysShape> shape;
		public float fadeDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<uint>(faction, name: "faction");
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
			fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
		}
		public override uint? ClassCRC => 0x1810F931;
	}
}

