namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EntityComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB114A2F7;
	}
}

