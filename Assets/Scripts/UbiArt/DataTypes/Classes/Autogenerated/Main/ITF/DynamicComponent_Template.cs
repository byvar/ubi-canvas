namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class DynamicComponent_Template : PhysComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDC4B1DAF;
	}
}

