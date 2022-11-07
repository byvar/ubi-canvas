namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GAWPattern : CSerializable {
		public Enum_VH_0 Enum_VH_0__0;
		public CArrayP<ushort> CArray_ushort__1;
		public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
				CArray_ushort__1 = s.SerializeObject<CArrayP<ushort>>(CArray_ushort__1, name: "CArray<unsigned short>__1");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

