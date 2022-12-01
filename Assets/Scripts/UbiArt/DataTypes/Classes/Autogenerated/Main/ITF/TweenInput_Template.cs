namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TweenInput_Template : TweenInstruction_Template {
		public StringID inputName;
		public float floatValue = float.MaxValue;
		public uint uintValue = uint.MaxValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputName = s.SerializeObject<StringID>(inputName, name: "inputName");
			floatValue = s.Serialize<float>(floatValue, name: "floatValue");
			uintValue = s.Serialize<uint>(uintValue, name: "uintValue");
		}
		public override uint? ClassCRC => 0x552239C3;
	}
}

