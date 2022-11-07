namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class SimpleTextComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x40BF0720;
	}
}

