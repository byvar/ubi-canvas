namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class DummyComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7DF03683;
	}
}

