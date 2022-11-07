namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SpawnedNPCComponent_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7EDA3217;
	}
}

