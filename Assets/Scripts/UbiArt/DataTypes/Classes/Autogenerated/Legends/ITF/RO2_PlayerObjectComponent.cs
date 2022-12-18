namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_PlayerObjectComponent : RO2_ActorObjectComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8F0022D7;
	}
}

