namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class CurveFollowerComponent_Template : CSerializable {
		public float speed;
		public int loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
			loop = s.Serialize<int>(loop, name: "loop");
		}
		public override uint? ClassCRC => 0xFBAD0887;
	}
}

