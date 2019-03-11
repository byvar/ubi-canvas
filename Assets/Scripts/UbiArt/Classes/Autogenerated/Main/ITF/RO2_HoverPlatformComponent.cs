using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_HoverPlatformComponent : ActorComponent {
		[Serialize("cycleEnabled"       )] public bool cycleEnabled;
		[Serialize("cycleStartIndex"    )] public uint cycleStartIndex;
		[Serialize("moveList"           )] public CList<RO2_moveData> moveList;
		[Serialize("wakeUpDir"          )] public Vector2 wakeUpDir;
		[Serialize("wakeUpPeriod"       )] public float wakeUpPeriod;
		[Serialize("wakeUpCycleCount"   )] public float wakeUpCycleCount;
		[Serialize("waitPeriod"         )] public float waitPeriod;
		[Serialize("waitDir"            )] public Vector2 waitDir;
		[Serialize("slowDuration"       )] public float slowDuration;
		[Serialize("stationaryDuration" )] public float stationaryDuration;
		[Serialize("fallDuration"       )] public float fallDuration;
		[Serialize("fallLength"         )] public float fallLength;
		[Serialize("fallAcceleration"   )] public float fallAcceleration;
		[Serialize("fallAccelarationMax")] public float fallAccelarationMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(cycleEnabled));
				SerializeField(s, nameof(cycleStartIndex));
				SerializeField(s, nameof(moveList));
				SerializeField(s, nameof(wakeUpDir));
				SerializeField(s, nameof(wakeUpPeriod));
				SerializeField(s, nameof(wakeUpCycleCount));
				SerializeField(s, nameof(waitPeriod));
				SerializeField(s, nameof(waitDir));
				SerializeField(s, nameof(slowDuration));
				SerializeField(s, nameof(stationaryDuration));
				SerializeField(s, nameof(fallDuration));
				SerializeField(s, nameof(fallLength));
				SerializeField(s, nameof(fallAcceleration));
				SerializeField(s, nameof(fallAccelarationMax));
			}
		}
		public override uint? ClassCRC => 0xCF8EB8A6;
	}
}

