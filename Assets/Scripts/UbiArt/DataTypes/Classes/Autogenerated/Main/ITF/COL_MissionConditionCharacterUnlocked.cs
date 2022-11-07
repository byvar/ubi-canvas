namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionCharacterUnlocked : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8FC1E20A;
	}
}

