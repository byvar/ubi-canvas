using UnityEngine;

namespace UbiArt.ITF {
	public partial class InputFrameData : CSerializable {
		[Serialize("InputFrame")] public uint InputFrame;
		[Serialize("InputPos"  )] public Vector2 InputPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(InputFrame));
			SerializeField(s, nameof(InputPos));
		}
		public override uint? ClassCRC => 0xF8039C30;
	}
}

