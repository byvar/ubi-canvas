using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MazeRoomComponent_Template : ActorComponent_Template {
		[Serialize("fadeInFactor" )] public float fadeInFactor;
		[Serialize("fadeOutFactor")] public float fadeOutFactor;
		[Serialize("portalTime"   )] public float portalTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fadeInFactor));
			SerializeField(s, nameof(fadeOutFactor));
			SerializeField(s, nameof(portalTime));
		}
		public override uint? ClassCRC => 0xE953E8F1;
	}
}

