namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Plane_Template : W1W_Vehicle_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x53ECA372;
	}
}

