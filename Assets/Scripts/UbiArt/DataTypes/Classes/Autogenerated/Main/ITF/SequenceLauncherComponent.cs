namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class SequenceLauncherComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2D457FFF;
	}
}

