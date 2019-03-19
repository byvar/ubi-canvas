using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class TweenBallistic_Template : TweenTranslation_Template {
		[Serialize("movement"         )] public Vector3 movement;
		[Serialize("tangentMode"      )] public TangentMode tangentMode;
		[Serialize("startTangent"     )] public Vector3 startTangent;
		[Serialize("disableCollisions")] public bool disableCollisions;
		[Serialize("tangentMode"      )] public Enum_RJR_0 tangentMode;
		[Serialize("disableCollisions")] public int disableCollisions;
		[Serialize("speed"            )] public float speed;
		[Serialize("tangentMode"      )] public Enum_tangentMode tangentMode;
		[Serialize("Vector3__0"       )] public Vector3 Vector3__0;
		[Serialize("Enum_RFR_0__1"    )] public Enum_RFR_0 Enum_RFR_0__1;
		[Serialize("Vector3__2"       )] public Vector3 Vector3__2;
		[Serialize("int__3"           )] public int int__3;
		[Serialize("float__4"         )] public float float__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(tangentMode));
				SerializeField(s, nameof(startTangent));
				SerializeField(s, nameof(disableCollisions));
				SerializeField(s, nameof(speed));
			} else if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Vector3__0));
				SerializeField(s, nameof(Enum_RFR_0__1));
				SerializeField(s, nameof(Vector3__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(float__4));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(tangentMode));
				SerializeField(s, nameof(startTangent));
				SerializeField(s, nameof(disableCollisions));
			} else {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(tangentMode));
				SerializeField(s, nameof(startTangent));
				SerializeField(s, nameof(disableCollisions));
			}
		}
		public enum TangentMode {
			[Serialize("TangentMode_Auto"  )] Auto = 0,
			[Serialize("TangentMode_Custom")] Custom = 1,
			[Serialize("TangentMode_Jump"  )] Jump = 2,
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_tangentMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x712F3B64;
	}
}

