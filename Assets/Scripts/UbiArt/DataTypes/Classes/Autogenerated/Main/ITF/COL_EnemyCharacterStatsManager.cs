namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EnemyCharacterStatsManager : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3E22684D;
	}
}

