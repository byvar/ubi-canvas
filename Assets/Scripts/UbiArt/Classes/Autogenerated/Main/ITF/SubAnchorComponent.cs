using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class SubAnchorComponent : ActorComponent {
		[Serialize("subAnchors")] public CList<SubAnchor> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnchors));
		}
		public override uint? ClassCRC => 0xE7EF05D1;
	}
}

