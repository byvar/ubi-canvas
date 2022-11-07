namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class InputDesc : CSerializable {
		public StringID name;
		public InputType varType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			varType = s.Serialize<InputType>(varType, name: "varType");
		}
		public enum InputType {
			[Serialize("InputType_F32")] F32 = 0,
			[Serialize("InputType_U32")] U32 = 1,
		}
	}
}

