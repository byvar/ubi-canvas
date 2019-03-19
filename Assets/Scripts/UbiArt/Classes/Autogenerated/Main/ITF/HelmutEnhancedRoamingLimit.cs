using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class HelmutEnhancedRoamingLimit : ActorComponent {
		[Serialize("StringID__0" )] public StringID StringID__0;
		[Serialize("StringID__1" )] public StringID StringID__1;
		[Serialize("float__2"    )] public float float__2;
		[Serialize("Enum_VH_0__3")] public Enum_VH_0 Enum_VH_0__3;
		[Serialize("uint__4"     )] public uint uint__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(Enum_VH_0__3));
			SerializeField(s, nameof(uint__4));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x0959EF43;
	}
}

