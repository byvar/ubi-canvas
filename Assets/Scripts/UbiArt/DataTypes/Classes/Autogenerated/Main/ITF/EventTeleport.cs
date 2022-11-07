namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventTeleport : Event {
		public bool applyPosAndAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			applyPosAndAngle = s.Serialize<bool>(applyPosAndAngle, name: "applyPosAndAngle");
		}
		public override uint? ClassCRC => 0x4017E956;
	}
}

