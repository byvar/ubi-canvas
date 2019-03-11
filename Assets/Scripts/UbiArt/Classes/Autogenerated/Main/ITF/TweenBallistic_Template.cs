using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenBallistic_Template : TweenTranslation_Template {
		[Serialize("movement"         )] public Vector3 movement;
		[Serialize("tangentMode"      )] public TangentMode tangentMode;
		[Serialize("startTangent"     )] public Vector3 startTangent;
		[Serialize("disableCollisions")] public bool disableCollisions;
		[Serialize("speed"            )] public float speed;
		[Serialize("tangentMode"      )] public Enum_tangentMode tangentMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(tangentMode));
				SerializeField(s, nameof(startTangent));
				SerializeField(s, nameof(disableCollisions));
				SerializeField(s, nameof(speed));
			} else if (Settings.s.game == Settings.Game.RL) {
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
		public enum TangentMode {
			[Serialize("TangentMode_Auto"  )] Auto = 0,
			[Serialize("TangentMode_Custom")] Custom = 1,
			[Serialize("TangentMode_Jump"  )] Jump = 2,
		}
		public enum Enum_tangentMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x712F3B64;
	}
}

