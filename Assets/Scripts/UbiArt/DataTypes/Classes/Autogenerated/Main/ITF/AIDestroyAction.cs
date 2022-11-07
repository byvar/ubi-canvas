namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class AIDestroyAction : AIAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x363A1459;
	}
}

