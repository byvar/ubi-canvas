using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SubAnchorComponent : ActorComponent {
		[Serialize("subAnchors")] public CList<Ray_SubAnchor> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnchors));
		}
		public override uint? ClassCRC => 0x220C7A1B;
	}
}

