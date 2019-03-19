using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GAWPattern : CSerializable {
		[Serialize("Enum_VH_0__0"             )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("CArray<unsigned short>__1")] public CArray<ushort> CArray_ushort__1;
		[Serialize("bool__2"                  )] public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Enum_VH_0__0));
				SerializeField(s, nameof(CArray_ushort__1));
				SerializeField(s, nameof(bool__2));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

