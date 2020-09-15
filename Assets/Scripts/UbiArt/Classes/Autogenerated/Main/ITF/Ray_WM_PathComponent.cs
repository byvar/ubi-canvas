using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_WM_PathComponent : ActorComponent {
		public Enum_RFR_0 Enum_RFR_0__0;
		public uint uint__1;
		public string string__2;
		public Vec2d Vector2__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_RFR_0__0 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__0, name: "Enum_RFR_0__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			string__2 = s.Serialize<string>(string__2, name: "string__2");
			Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xAE75EA5A;
	}
}

