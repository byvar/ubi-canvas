namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_ProjectileComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCD961E71;
	}
}

