namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class CurveComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1AC7C5B4;
	}
}

