namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_MultiPiecesActorAIComponent : RO2_AIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCD0E695A;
	}
}

