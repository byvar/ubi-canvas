namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_SaveNotificationComponent_Template : SaveNotificationComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA34632A9;
	}
}

