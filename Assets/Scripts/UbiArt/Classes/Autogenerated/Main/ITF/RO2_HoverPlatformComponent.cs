using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_HoverPlatformComponent : ActorComponent {
		public bool cycleEnabled;
		public uint cycleStartIndex;
		public CListO<RO2_moveData> moveList;
		public Vec2d wakeUpDir;
		public float wakeUpPeriod;
		public float wakeUpCycleCount;
		public float waitPeriod;
		public Vec2d waitDir;
		public float slowDuration;
		public float stationaryDuration;
		public float fallDuration;
		public float fallLength;
		public float fallAcceleration;
		public float fallAccelarationMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				cycleEnabled = s.Serialize<bool>(cycleEnabled, name: "cycleEnabled");
				cycleStartIndex = s.Serialize<uint>(cycleStartIndex, name: "cycleStartIndex");
				moveList = s.SerializeObject<CListO<RO2_moveData>>(moveList, name: "moveList");
				wakeUpDir = s.SerializeObject<Vec2d>(wakeUpDir, name: "wakeUpDir");
				wakeUpPeriod = s.Serialize<float>(wakeUpPeriod, name: "wakeUpPeriod");
				wakeUpCycleCount = s.Serialize<float>(wakeUpCycleCount, name: "wakeUpCycleCount");
				waitPeriod = s.Serialize<float>(waitPeriod, name: "waitPeriod");
				waitDir = s.SerializeObject<Vec2d>(waitDir, name: "waitDir");
				slowDuration = s.Serialize<float>(slowDuration, name: "slowDuration");
				stationaryDuration = s.Serialize<float>(stationaryDuration, name: "stationaryDuration");
				fallDuration = s.Serialize<float>(fallDuration, name: "fallDuration");
				fallLength = s.Serialize<float>(fallLength, name: "fallLength");
				fallAcceleration = s.Serialize<float>(fallAcceleration, name: "fallAcceleration");
				fallAccelarationMax = s.Serialize<float>(fallAccelarationMax, name: "fallAccelarationMax");
			}
		}
		public override uint? ClassCRC => 0xCF8EB8A6;
	}
}

