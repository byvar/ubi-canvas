namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ScaleTunnelComponent_Template : ActorComponent_Template {
		public PhysShapeBox area;
		public float scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			area = s.SerializeObject<PhysShapeBox>(area, name: "area");
			scale = s.Serialize<float>(scale, name: "scale");
		}
		public override uint? ClassCRC => 0x1A08EAF7;
	}
}

