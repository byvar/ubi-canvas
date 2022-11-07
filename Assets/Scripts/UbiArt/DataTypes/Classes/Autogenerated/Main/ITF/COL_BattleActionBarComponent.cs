namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleActionBarComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDDA01CA1;
	}
}

