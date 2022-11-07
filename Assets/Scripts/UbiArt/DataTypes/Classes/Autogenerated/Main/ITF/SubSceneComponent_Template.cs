namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class SubSceneComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE5DC91AE;
	}
}

