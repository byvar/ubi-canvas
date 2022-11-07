namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class SingleAnimData : CSerializable {
		public bool flip;
		public Angle angle;
		public StringID animName;
		public uint offset;
		public Vec3d pos;
		public Vec2d scale;
		public Color color;
		public uint anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flip = s.Serialize<bool>(flip, name: "flip");
			angle = s.SerializeObject<Angle>(angle, name: "angle");
			animName = s.SerializeObject<StringID>(animName, name: "animName");
			offset = s.Serialize<uint>(offset, name: "offset");
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
			scale = s.SerializeObject<Vec2d>(scale, name: "scale");
			color = s.SerializeObject<Color>(color, name: "color");
			anim = s.Serialize<uint>(anim, name: "anim");
		}
		public override uint? ClassCRC => 0x38A1A554;
	}
}

