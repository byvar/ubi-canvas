namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_MagnetGadgetAIComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x85057206;
	}
}

