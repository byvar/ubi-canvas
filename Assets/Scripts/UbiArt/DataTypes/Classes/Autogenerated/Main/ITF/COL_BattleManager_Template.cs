namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleManager_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1B7CC328;
	}
}

