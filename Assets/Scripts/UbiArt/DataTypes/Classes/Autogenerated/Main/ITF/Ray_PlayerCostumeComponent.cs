namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_PlayerCostumeComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD8B5DF48;
	}
}

