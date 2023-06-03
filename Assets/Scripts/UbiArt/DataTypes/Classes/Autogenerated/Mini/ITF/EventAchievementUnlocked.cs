namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventAchievementUnlocked : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1C7AD8DD;
	}
}

