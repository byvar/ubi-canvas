namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterPirateShipAIComponent : RO2_MultiPiecesActorAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x025AFE64;
	}
}

