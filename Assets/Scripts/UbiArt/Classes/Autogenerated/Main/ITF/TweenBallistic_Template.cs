using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class TweenBallistic_Template : TweenTranslation_Template {
		[Serialize("movement"         )] public Vector3 movement;
		[Serialize("tangentMode"      )] public TangentMode tangentMode;
		[Serialize("startTangent"     )] public Vector3 startTangent;
		[Serialize("disableCollisions")] public bool disableCollisions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(tangentMode));
				SerializeField(s, nameof(startTangent));
				SerializeField(s, nameof(disableCollisions));
				SerializeField(s, nameof(speed));
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
		public override uint? ClassCRC => 0x712F3B64;
	}
}

