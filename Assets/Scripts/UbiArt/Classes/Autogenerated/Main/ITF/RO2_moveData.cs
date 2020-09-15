using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_moveData : CSerializable {
		[Serialize("dir"            )] public Vec2d dir;
		[Serialize("period"         )] public float period;
		[Serialize("cycle"          )] public bool cycle;
		[Serialize("autoStart"      )] public bool autoStart;
		[Serialize("delayCycleCount")] public float delayCycleCount;
		[Serialize("playFxAttach"   )] public bool playFxAttach;
		[Serialize("playFxMove"     )] public bool playFxMove;
		[Serialize("playFxDetach"   )] public bool playFxDetach;
		[Serialize("pauseFxInWait"  )] public bool pauseFxInWait;
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
				if (Settings.s.game == Settings.Game.RL) {
					SerializeField(s, nameof(pauseFxInWait));
				}
			}
		}
	}
}

