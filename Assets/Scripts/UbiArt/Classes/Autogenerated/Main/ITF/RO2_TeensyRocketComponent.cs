using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TeensyRocketComponent : ActorComponent {
		[Serialize("time"       )] public float time;
		[Serialize("displayRope")] public bool displayRope;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(time));
			} else {
				SerializeField(s, nameof(time));
				SerializeField(s, nameof(displayRope));
			}
		}
		public override uint? ClassCRC => 0x7333CF6D;
	}
}

