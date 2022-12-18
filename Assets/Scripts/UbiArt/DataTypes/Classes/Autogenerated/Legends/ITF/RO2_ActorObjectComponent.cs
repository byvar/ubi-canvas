namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ActorObjectComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x45F01C95;
	}
}

