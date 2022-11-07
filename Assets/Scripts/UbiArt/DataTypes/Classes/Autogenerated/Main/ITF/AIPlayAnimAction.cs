namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class AIPlayAnimAction : AIAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2E46A7B1;
	}
}

