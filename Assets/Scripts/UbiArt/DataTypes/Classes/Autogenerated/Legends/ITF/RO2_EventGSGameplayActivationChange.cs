namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventGSGameplayActivationChange : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x79B5F10D;
	}
}

