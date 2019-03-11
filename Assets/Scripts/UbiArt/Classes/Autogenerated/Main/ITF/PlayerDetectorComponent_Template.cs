using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayerDetectorComponent_Template : ShapeDetectorComponent_Template {
		[Serialize("allowDeadActors"       )] public bool allowDeadActors;
		[Serialize("firstPlayerOnly"       )] public bool firstPlayerOnly;
		[Serialize("allPlayerInMode"       )] public uint allPlayerInMode;
		[Serialize("maxDetectionRadius"    )] public float maxDetectionRadius;
		[Serialize("allowTouchScreenPlayer")] public bool allowTouchScreenPlayer;
		[Serialize("ignoreZ"               )] public bool ignoreZ;
		[Serialize("drcPlayerOnly"         )] public bool drcPlayerOnly;
		[Serialize("detectPivotOnly"       )] public bool detectPivotOnly;
		[Serialize("playerId"              )] public bool playerId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(playerId));
				SerializeField(s, nameof(allowDeadActors));
				SerializeField(s, nameof(firstPlayerOnly));
				SerializeField(s, nameof(allPlayerInMode));
				SerializeField(s, nameof(maxDetectionRadius));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(allowDeadActors));
				SerializeField(s, nameof(firstPlayerOnly));
				SerializeField(s, nameof(allPlayerInMode));
				SerializeField(s, nameof(maxDetectionRadius));
				SerializeField(s, nameof(allowTouchScreenPlayer));
				SerializeField(s, nameof(ignoreZ));
				SerializeField(s, nameof(drcPlayerOnly));
			} else {
				SerializeField(s, nameof(allowDeadActors));
				SerializeField(s, nameof(firstPlayerOnly));
				SerializeField(s, nameof(allPlayerInMode));
				SerializeField(s, nameof(maxDetectionRadius));
				SerializeField(s, nameof(allowTouchScreenPlayer));
				SerializeField(s, nameof(ignoreZ));
				SerializeField(s, nameof(drcPlayerOnly));
				SerializeField(s, nameof(detectPivotOnly));
			}
		}
		public override uint? ClassCRC => 0x3A92D482;
	}
}

