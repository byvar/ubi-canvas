namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class BossComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA2B6F942;
	}
}

