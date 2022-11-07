namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventFlare_PlayerIsDetected : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x13871EFC;
	}
}

