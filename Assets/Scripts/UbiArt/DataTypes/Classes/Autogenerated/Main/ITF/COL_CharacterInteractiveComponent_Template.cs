namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterInteractiveComponent_Template : CSerializable {
		public Enum_characterType characterType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			characterType = s.Serialize<Enum_characterType>(characterType, name: "characterType");
		}
		public enum Enum_characterType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x1D8C5A99;
	}
}

