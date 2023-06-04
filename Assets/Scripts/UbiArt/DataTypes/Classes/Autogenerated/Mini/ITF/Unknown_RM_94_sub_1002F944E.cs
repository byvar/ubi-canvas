namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventGameGlobalsConditionChanged : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6A221E51;
	}
}

