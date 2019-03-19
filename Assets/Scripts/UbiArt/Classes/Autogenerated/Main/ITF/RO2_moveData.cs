using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_moveData : CSerializable {
		[Serialize("dir"            )] public Vector2 dir;
		[Serialize("period"         )] public float period;
		[Serialize("cycle"          )] public bool cycle;
		[Serialize("autoStart"      )] public bool autoStart;
		[Serialize("delayCycleCount")] public float delayCycleCount;
		[Serialize("playFxAttach"   )] public bool playFxAttach;
		[Serialize("playFxMove"     )] public bool playFxMove;
		[Serialize("playFxDetach"   )] public bool playFxDetach;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(dir));
				SerializeField(s, nameof(period));
				SerializeField(s, nameof(cycle));
				SerializeField(s, nameof(autoStart));
				SerializeField(s, nameof(delayCycleCount));
				SerializeField(s, nameof(playFxAttach));
				SerializeField(s, nameof(playFxMove));
				SerializeField(s, nameof(playFxDetach));
			}
		}
	}
}

