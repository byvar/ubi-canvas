namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Curve2DControlPoint : CSerializable {
		public float x;
		public float y;
		public float leftTan;
		public float rightTan = float.MaxValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			x = s.Serialize<float>(x, name: "x");
			y = s.Serialize<float>(y, name: "y");
			leftTan = s.Serialize<float>(leftTan, name: "leftTan");
			rightTan = s.Serialize<float>(rightTan, name: "rightTan");
		}
	}
}

