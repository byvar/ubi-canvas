using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ShadowZonePlayerDetectorComponent_Template : DetectorComponent_Template {
		[Serialize("playerId"              )] public int playerId;
		[Serialize("allowDeadActors"       )] public bool allowDeadActors;
		[Serialize("firstPlayerOnly"       )] public bool firstPlayerOnly;
		[Serialize("allPlayerInMode"       )] public uint allPlayerInMode;
		[Serialize("allowTouchScreenPlayer")] public bool allowTouchScreenPlayer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerId));
			SerializeField(s, nameof(allowDeadActors));
			SerializeField(s, nameof(firstPlayerOnly));
			SerializeField(s, nameof(allPlayerInMode));
			SerializeField(s, nameof(allowTouchScreenPlayer));
		}
		public override uint? ClassCRC => 0xE855E934;
	}
}

