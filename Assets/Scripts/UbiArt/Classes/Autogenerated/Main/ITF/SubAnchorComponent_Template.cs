using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class SubAnchorComponent_Template : ActorComponent_Template {
		public CList<SubAnchor_Template> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			subAnchors = s.SerializeObject<CList<SubAnchor_Template>>(subAnchors, name: "subAnchors");
		}
		public override uint? ClassCRC => 0x839E4DD5;
	}
}

