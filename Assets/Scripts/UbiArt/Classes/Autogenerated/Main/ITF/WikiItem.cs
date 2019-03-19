using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class WikiItem : CSerializable {
		[Serialize("uint__0"     )] public uint uint__0;
		[Serialize("Enum_VH_0__1")] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("Path__2"     )] public Path Path__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(Enum_VH_0__1));
			SerializeField(s, nameof(Path__2));
		}
		public enum Enum_VH_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
		}
	}
}

