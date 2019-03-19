using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIFriendly_WaitBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("idle"                )] public Placeholder idle;
		[Serialize("randomAction"        )] public Placeholder randomAction;
		[Serialize("triggerTarget"       )] public int triggerTarget;
		[Serialize("randomActionDelayMin")] public float randomActionDelayMin;
		[Serialize("randomActionDelayMax")] public float randomActionDelayMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(randomAction));
			SerializeField(s, nameof(triggerTarget));
			SerializeField(s, nameof(randomActionDelayMin));
			SerializeField(s, nameof(randomActionDelayMax));
		}
		public override uint? ClassCRC => 0xF99358B5;
	}
}

