namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ReflectionComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD65D8737;
	}
}

