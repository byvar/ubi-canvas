namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Plane : W1W_Vehicle {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFEC79237;
	}
}

