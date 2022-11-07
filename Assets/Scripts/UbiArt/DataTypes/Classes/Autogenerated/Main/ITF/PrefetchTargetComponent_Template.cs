namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PrefetchTargetComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC2C35A51;
	}
}

