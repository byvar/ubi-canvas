namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PolygonWindComponent_Template : PhysForceModifierComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDF9F7F7A;
	}
}

