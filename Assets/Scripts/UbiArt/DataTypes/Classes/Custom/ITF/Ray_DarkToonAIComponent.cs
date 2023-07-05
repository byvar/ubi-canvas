namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_DarkToonAIComponent : Ray_GroundAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEA54E2CB;
	}
}

