using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_moveData : CSerializable {
		public Vec2d dir;
		public float period;
		public bool cycle;
		public bool autoStart;
		public float delayCycleCount;
		public bool playFxAttach;
		public bool playFxMove;
		public bool playFxDetach;
		public bool pauseFxInWait;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				dir = s.SerializeObject<Vec2d>(dir, name: "dir");
				period = s.Serialize<float>(period, name: "period");
				cycle = s.Serialize<bool>(cycle, name: "cycle");
				autoStart = s.Serialize<bool>(autoStart, name: "autoStart");
				delayCycleCount = s.Serialize<float>(delayCycleCount, name: "delayCycleCount");
				playFxAttach = s.Serialize<bool>(playFxAttach, name: "playFxAttach");
				playFxMove = s.Serialize<bool>(playFxMove, name: "playFxMove");
				playFxDetach = s.Serialize<bool>(playFxDetach, name: "playFxDetach");
				if (Settings.s.game == Settings.Game.RL) {
					pauseFxInWait = s.Serialize<bool>(pauseFxInWait, name: "pauseFxInWait");
				}
			}
		}
	}
}

