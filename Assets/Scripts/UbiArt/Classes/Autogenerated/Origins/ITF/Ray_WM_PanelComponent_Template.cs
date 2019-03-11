using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_WM_PanelComponent_Template : CSerializable {
		[Serialize("offset"      )] public Vector2 offset;
		[Serialize("bone"        )] public StringID bone;
		[Serialize("electoonPath")] public Path electoonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(bone));
			SerializeField(s, nameof(electoonPath));
		}
		public override uint? ClassCRC => 0x24AAB2B2;
	}
}

