using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class InputFrameData : CSerializable {
		public uint InputFrame;
		public Vec2d InputPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			InputFrame = s.Serialize<uint>(InputFrame, name: "InputFrame");
			InputPos = s.SerializeObject<Vec2d>(InputPos, name: "InputPos");
		}
		public override uint? ClassCRC => 0xF8039C30;
	}
}

