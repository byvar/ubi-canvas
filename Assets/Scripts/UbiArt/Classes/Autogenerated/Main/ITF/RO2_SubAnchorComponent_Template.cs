using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_SubAnchorComponent_Template : ActorComponent_Template {
		[Serialize("subAnchors")] public CList<RO2_SubAnchor_Template> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnchors));
		}
		public override uint? ClassCRC => 0x839E4DD5;
	}
}

