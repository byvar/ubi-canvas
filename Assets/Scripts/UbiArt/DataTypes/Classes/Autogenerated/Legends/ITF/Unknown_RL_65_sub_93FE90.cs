namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.RM)]
	public partial class PhysForceModifierPolygon : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6C553A9E;
	}
}

