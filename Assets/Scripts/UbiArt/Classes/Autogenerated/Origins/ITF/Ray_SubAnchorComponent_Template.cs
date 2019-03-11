using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SubAnchorComponent_Template : CSerializable {
		[Serialize("subAnchors")] public Placeholder subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnchors));
		}
		public override uint? ClassCRC => 0x900C8919;
	}
}

