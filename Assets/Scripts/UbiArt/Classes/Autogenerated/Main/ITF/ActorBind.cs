using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class ActorBind : CSerializable {
		[Serialize("ObjectPath__0" )] public ObjectPath ObjectPath__0;
		[Serialize("Vector3__1"    )] public Vector3 Vector3__1;
		[Serialize("float__2"      )] public float float__2;
		[Serialize("Enum_RJR_0__3" )] public Enum_RJR_0 Enum_RJR_0__3;
		[Serialize("uint__4"       )] public uint uint__4;
		[Serialize("int__5"        )] public int int__5;
		[Serialize("int__6"        )] public int int__6;
		[Serialize("int__7"        )] public int int__7;
		[Serialize("ObjectPath__8" )] public ObjectPath ObjectPath__8;
		[Serialize("Vector3__9"    )] public Vector3 Vector3__9;
		[Serialize("float__10"     )] public float float__10;
		[Serialize("Enum_RFR_0__11")] public Enum_RFR_0 Enum_RFR_0__11;
		[Serialize("uint__12"      )] public uint uint__12;
		[Serialize("int__13"       )] public int int__13;
		[Serialize("int__14"       )] public int int__14;
		[Serialize("int__15"       )] public int int__15;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(ObjectPath__8));
					SerializeField(s, nameof(Vector3__9));
					SerializeField(s, nameof(float__10));
					SerializeField(s, nameof(Enum_RFR_0__11));
					SerializeField(s, nameof(uint__12));
					if (s.HasFlags(SerializeFlags.Flags_x03)) {
						SerializeField(s, nameof(int__13));
						SerializeField(s, nameof(int__14));
						SerializeField(s, nameof(int__15));
					}
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(ObjectPath__0));
					SerializeField(s, nameof(Vector3__1));
					SerializeField(s, nameof(float__2));
					SerializeField(s, nameof(Enum_RJR_0__3));
					SerializeField(s, nameof(uint__4));
					if (s.HasFlags(SerializeFlags.Flags_x03)) {
						SerializeField(s, nameof(int__5));
						SerializeField(s, nameof(int__6));
						SerializeField(s, nameof(int__7));
					}
				}
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

