namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Torchlight_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEB4C4AEF;
	}
}

