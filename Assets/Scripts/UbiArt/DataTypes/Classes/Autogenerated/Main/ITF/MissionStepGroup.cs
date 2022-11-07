namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepGroup : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBCD5C9C5;
	}
}

