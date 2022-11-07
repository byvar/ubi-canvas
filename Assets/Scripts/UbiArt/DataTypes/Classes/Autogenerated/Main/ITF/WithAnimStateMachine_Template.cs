namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class WithAnimStateMachine_Template : BasicStateMachine_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFB7724C4;
	}
}

