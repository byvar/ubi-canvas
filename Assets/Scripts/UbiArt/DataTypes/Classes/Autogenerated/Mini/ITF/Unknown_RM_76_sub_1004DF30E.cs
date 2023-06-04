namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class TriggerSelectionAbstract : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC362F6F0;
	}
}

