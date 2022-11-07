namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class SetChildren2DNoScreenRatioComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF41B09B0;
	}
}

