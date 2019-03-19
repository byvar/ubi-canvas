using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_FluidFallAIComponent : GraphicComponent {
		[Serialize("uvMode"       )] public Enum_RJR_0 uvMode;
		[Serialize("startOpen"    )] public int startOpen;
		[Serialize("widthStart"   )] public float widthStart;
		[Serialize("widthBase"    )] public float widthBase;
		[Serialize("speed"        )] public float speed;
		[Serialize("Enum_RFR_0__0")] public Enum_RFR_0 Enum_RFR_0__0;
		[Serialize("int__1"       )] public int int__1;
		[Serialize("float__2"     )] public float float__2;
		[Serialize("float__3"     )] public float float__3;
		[Serialize("float__4"     )] public float float__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Enum_RFR_0__0));
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(int__1));
					SerializeField(s, nameof(float__2));
					SerializeField(s, nameof(float__3));
					SerializeField(s, nameof(float__4));
				}
			} else {
				SerializeField(s, nameof(uvMode));
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(startOpen));
					SerializeField(s, nameof(widthStart));
					SerializeField(s, nameof(widthBase));
					SerializeField(s, nameof(speed));
				}
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x7FC096B9;
	}
}

