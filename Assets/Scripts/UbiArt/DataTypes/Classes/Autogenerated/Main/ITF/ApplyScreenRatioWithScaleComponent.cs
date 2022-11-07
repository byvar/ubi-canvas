namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class ApplyScreenRatioWithScaleComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE7215E3E;
	}
}

