using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_SubAnchorComponent_Template : ActorComponent_Template {
		public CListO<Ray_SubAnchor_Template> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			subAnchors = s.SerializeObject<CListO<Ray_SubAnchor_Template>>(subAnchors, name: "subAnchors");
		}
		public override uint? ClassCRC => 0x900C8919;
	}
}

