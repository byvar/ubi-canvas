using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class SubAnchorComponent : ActorComponent {
		public CListO<SubAnchor> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			subAnchors = s.SerializeObject<CListO<SubAnchor>>(subAnchors, name: "subAnchors");
		}
		public override uint? ClassCRC => 0xE7EF05D1;
	}
}

