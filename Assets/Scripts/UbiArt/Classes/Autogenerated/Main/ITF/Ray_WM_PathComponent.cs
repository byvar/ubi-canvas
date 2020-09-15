using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_WM_PathComponent : ActorComponent {
		[Serialize("Enum_RFR_0__0")] public Enum_RFR_0 Enum_RFR_0__0;
		[Serialize("uint__1"      )] public uint uint__1;
		[Serialize("string__2"    )] public string string__2;
		[Serialize("Vector2__3"   )] public Vec2d Vector2__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_RFR_0__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(string__2));
			SerializeField(s, nameof(Vector2__3));
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xAE75EA5A;
	}
}

