using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubRenderParam_ColorRamp : SubRenderParam {
		[Serialize("ColorRampPath")] public Path ColorRampPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ColorRampPath));
		}
		public override uint? ClassCRC => 0x1B6979E9;
	}
}

