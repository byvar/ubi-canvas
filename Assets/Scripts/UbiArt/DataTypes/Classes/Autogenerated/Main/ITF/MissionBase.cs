namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionBase : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1B0F1128;
	}
}

