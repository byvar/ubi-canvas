namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionConditionStoryEvent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8004F736;
	}
}

