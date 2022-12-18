namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuDRCComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEAECE6AF;
	}
}

