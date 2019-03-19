using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class PolyLineEdge : CSerializable {
		[Serialize("POS"             )] public Vector2 POS;
		[Serialize("Scale"           )] public float Scale;
		[Serialize("SwitchTexture"   )] public bool SwitchTexture;
		[Serialize("GMatOverride"    )] public StringID GMatOverride;
		[Serialize("HoleMode"        )] public Hole HoleMode;
		[Serialize("Vector"          )] public Vector2 Vector;
		[Serialize("NormalizedVector")] public Vector2 NormalizedVector;
		[Serialize("Length"          )] public float Length;
		[Serialize("GameMaterial"    )] public StringID GameMaterial;
		[Serialize("Vector2__0"      )] public Vector2 Vector2__0;
		[Serialize("Enum_RJR_0__1"   )] public Enum_RJR_0 Enum_RJR_0__1;
		[Serialize("float__2"        )] public float float__2;
		[Serialize("int__3"          )] public int int__3;
		[Serialize("Vector2__4"      )] public Vector2 Vector2__4;
		[Serialize("Enum_RFR_0__5"   )] public Enum_RFR_0 Enum_RFR_0__5;
		[Serialize("float__6"        )] public float float__6;
		[Serialize("int__7"          )] public int int__7;
		[Serialize("Vector2__8"      )] public Vector2 Vector2__8;
		[Serialize("float__9"        )] public float float__9;
		[Serialize("bool__10"        )] public bool bool__10;
		[Serialize("Enum_VH_0__11"   )] public Enum_VH_0 Enum_VH_0__11;
		[Serialize("Vector2__12"     )] public Vector2 Vector2__12;
		[Serialize("Vector2__13"     )] public Vector2 Vector2__13;
		[Serialize("float__14"       )] public float float__14;
		[Serialize("StringID__15"    )] public StringID StringID__15;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					SerializeField(s, nameof(Vector2__0));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Enum_RJR_0__1));
					SerializeField(s, nameof(float__2));
					SerializeField(s, nameof(int__3));
				}
			} else if (Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					SerializeField(s, nameof(Vector2__4));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Enum_RFR_0__5));
					SerializeField(s, nameof(float__6));
					SerializeField(s, nameof(int__7));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Vector2__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(Enum_VH_0__11));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(Vector2__12));
					SerializeField(s, nameof(Vector2__13));
					SerializeField(s, nameof(float__14));
					SerializeField(s, nameof(StringID__15));
				}
			} else {
				SerializeField(s, nameof(POS));
				SerializeField(s, nameof(Scale));
				SerializeField(s, nameof(SwitchTexture));
				SerializeField(s, nameof(GMatOverride));
				SerializeField(s, nameof(HoleMode));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(Vector));
					SerializeField(s, nameof(NormalizedVector));
					SerializeField(s, nameof(Length));
					SerializeField(s, nameof(GameMaterial));
				}
			}
		}
		public enum Hole {
			[Serialize("Hole_None"     )] None = 0,
			[Serialize("Hole_Collision")] Collision = 1,
			[Serialize("Hole_Visual"   )] Visual = 2,
			[Serialize("Hole_Both"     )] Both = 3,
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
	}
}

