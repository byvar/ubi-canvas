namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepDelay : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x043D66B5;
	}
}

