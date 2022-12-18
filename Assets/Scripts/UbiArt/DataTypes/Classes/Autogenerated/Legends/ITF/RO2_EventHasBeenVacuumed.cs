namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventHasBeenVacuumed : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x924C0AD0;
	}
}

