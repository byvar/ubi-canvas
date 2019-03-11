using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_WM_PanelComponent : CSerializable {
		[Serialize("tag")] public StringID tag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tag));
		}
		public override uint? ClassCRC => 0x3F4A4919;
	}
}

