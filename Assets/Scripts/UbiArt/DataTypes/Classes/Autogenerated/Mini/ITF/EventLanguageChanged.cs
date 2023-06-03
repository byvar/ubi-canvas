namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventLanguageChanged : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3D5DF2C7;
	}
}

