using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnchorComponent_Template : ActorComponent_Template {
		[Serialize("subAnchors")] public CList<SubAnchor_Template> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(subAnchors));
		}
		public override uint? ClassCRC => 0x839E4DD5;
	}
}

