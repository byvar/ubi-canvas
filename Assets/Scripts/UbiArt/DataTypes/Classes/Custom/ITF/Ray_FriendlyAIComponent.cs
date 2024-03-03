namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FriendlyAIComponent : Ray_GroundAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC365623E;
	}
}

