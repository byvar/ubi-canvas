namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepMovie : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x96F2B22C;
	}
}

