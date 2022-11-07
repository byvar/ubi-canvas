namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Rack_Template : W1W_InteractiveGenComponent_Template {
		public float float__0;
		public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
		}
		public override uint? ClassCRC => 0x0BABE78E;
	}
}

