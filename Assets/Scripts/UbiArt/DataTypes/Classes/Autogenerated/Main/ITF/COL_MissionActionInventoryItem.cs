namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionInventoryItem : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6327AA1E;
	}
}

