namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AllyCharacterStatsManager : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF97FE38A;
	}
}

