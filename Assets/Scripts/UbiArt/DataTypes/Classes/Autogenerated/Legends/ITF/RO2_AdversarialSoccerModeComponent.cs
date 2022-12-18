namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AdversarialSoccerModeComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA38D7D0F;
	}
}

