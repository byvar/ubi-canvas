namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventDisableFlying : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x679A0B92;
	}
}

