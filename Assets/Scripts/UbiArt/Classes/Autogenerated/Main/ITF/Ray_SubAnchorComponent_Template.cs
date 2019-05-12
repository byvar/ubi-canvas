using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SubAnchorComponent_Template : ActorComponent_Template {
		[Serialize("subAnchors")] public CList<Ray_SubAnchor_Template> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnchors));
		}
		public override uint? ClassCRC => 0x900C8919;
	}
}

