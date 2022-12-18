namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class StateHit_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7626EE22;
	}
}

