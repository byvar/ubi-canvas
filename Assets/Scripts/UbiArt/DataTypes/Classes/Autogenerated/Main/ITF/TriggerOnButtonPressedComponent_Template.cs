namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class TriggerOnButtonPressedComponent_Template : TriggerComponent_Template {
		public CListP<uint> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputs = s.SerializeObject<CListP<uint>>(inputs, name: "inputs");
		}
		public override uint? ClassCRC => 0x655C4B1F;
	}
}

