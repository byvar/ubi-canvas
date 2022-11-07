namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_BezierCustomDistanceNodeComponent : ActorComponent {
		public int int__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			int__0 = s.Serialize<int>(int__0, name: "int__0");
		}
		public override uint? ClassCRC => 0x5EA4F01D;
	}
}

