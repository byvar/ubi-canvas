namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EnvironmentComponent_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3D71D167;
	}
}

