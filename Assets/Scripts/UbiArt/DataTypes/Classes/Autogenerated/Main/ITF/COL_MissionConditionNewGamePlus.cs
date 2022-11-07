namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionConditionNewGamePlus : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF142B89B;
	}
}

