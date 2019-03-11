using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionRoaming_Template : BTAction_Template {
		[Serialize("animWalk"    )] public StringID animWalk;
		[Serialize("animUTurn"   )] public StringID animUTurn;
		[Serialize("useFlipEvent")] public bool useFlipEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(animWalk));
				SerializeField(s, nameof(animUTurn));
			} else {
				SerializeField(s, nameof(animWalk));
				SerializeField(s, nameof(animUTurn));
				SerializeField(s, nameof(useFlipEvent));
			}
		}
		public override uint? ClassCRC => 0x520E8E0C;
	}
}

