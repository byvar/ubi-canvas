using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_SubAnchorComponent : ActorComponent {
		public CList<RO2_SubAnchor> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			subAnchors = s.SerializeObject<CList<RO2_SubAnchor>>(subAnchors, name: "subAnchors");
		}
		public override uint? ClassCRC => 0xE7EF05D1;
	}
}

