using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SubAnchorComponent : ActorComponent {
		[Serialize("subAnchors")] public CList<RO2_SubAnchor> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnchors));
		}
		public override uint? ClassCRC => 0xE7EF05D1;
	}
}

