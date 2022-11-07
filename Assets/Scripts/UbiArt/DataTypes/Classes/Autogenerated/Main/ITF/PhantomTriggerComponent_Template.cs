namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PhantomTriggerComponent_Template : TriggerComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD0F154BF;
	}
}

