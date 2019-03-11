using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SubAnchorComponent : CSerializable {
		[Serialize("subAnchors")] public Placeholder subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnchors));
		}
		public override uint? ClassCRC => 0x220C7A1B;
	}
}

