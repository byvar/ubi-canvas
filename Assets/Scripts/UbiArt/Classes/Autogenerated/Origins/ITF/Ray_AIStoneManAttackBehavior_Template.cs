using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIStoneManAttackBehavior_Template : BlendTreeNodeTemplate<AnimTreeResult> {
		[Serialize("respawnBoulder")] public Placeholder respawnBoulder;
		[Serialize("idle"          )] public Placeholder idle;
		[Serialize("anticipation"  )] public Placeholder anticipation;
		[Serialize("sleep"         )] public Placeholder sleep;
		[Serialize("wakeUp"        )] public Placeholder wakeUp;
		[Serialize("launchActions" )] public Placeholder launchActions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(respawnBoulder));
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(anticipation));
			SerializeField(s, nameof(sleep));
			SerializeField(s, nameof(wakeUp));
			SerializeField(s, nameof(launchActions));
		}
		public override uint? ClassCRC => 0x8DE04F71;
	}
}

