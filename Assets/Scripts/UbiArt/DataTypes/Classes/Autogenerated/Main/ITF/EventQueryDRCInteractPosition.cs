namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventQueryDRCInteractPosition : Event {
		public Vec2d position;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			position = s.SerializeObject<Vec2d>(position, name: "position");
		}
		public override uint? ClassCRC => 0x03B0E285;
	}
}

