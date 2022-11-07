namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class AfterFxComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x721E1295;
	}
}

