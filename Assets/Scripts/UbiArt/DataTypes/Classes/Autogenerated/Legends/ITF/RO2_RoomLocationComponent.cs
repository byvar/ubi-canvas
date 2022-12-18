namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_RoomLocationComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x21B510BF;
	}
}

