namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventCollectibleFound : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD2C3D830;
	}
}

