namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class Phys3DComponent_Template : ActorComponent_Template {
		public float gravity;
		public float friction;
		public float mass;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gravity = s.Serialize<float>(gravity, name: "gravity");
			friction = s.Serialize<float>(friction, name: "friction");
			mass = s.Serialize<float>(mass, name: "mass");
		}
		public override uint? ClassCRC => 0xA65D5F48;
	}
}

