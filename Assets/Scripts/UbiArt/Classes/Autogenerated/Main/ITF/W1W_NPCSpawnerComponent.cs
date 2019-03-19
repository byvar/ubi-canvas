using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_NPCSpawnerComponent : ActorComponent {
		[Serialize("Path__0"     )] public Path Path__0;
		[Serialize("uint__1"     )] public uint uint__1;
		[Serialize("Enum_VH_0__2")] public Enum_VH_0 Enum_VH_0__2;
		[Serialize("Vector2__3"  )] public Vector2 Vector2__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(Enum_VH_0__2));
			SerializeField(s, nameof(Vector2__3));
		}
		public enum Enum_VH_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_1" )] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x64E51342;
	}
}

