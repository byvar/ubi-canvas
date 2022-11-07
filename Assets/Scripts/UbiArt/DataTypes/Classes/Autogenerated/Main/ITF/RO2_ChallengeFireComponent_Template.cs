namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ChallengeFireComponent_Template : ActorComponent_Template {
		public uint faction;
		public Generic<PhysShape> shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<uint>(faction, name: "faction");
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
		}
		public override uint? ClassCRC => 0x93E43FDB;
	}
}

