namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_TargetingCreatureDisplay : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD3B771F4;
	}
}

