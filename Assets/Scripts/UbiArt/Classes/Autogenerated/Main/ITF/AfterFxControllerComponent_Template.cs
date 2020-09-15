using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH)]
	public partial class AfterFxControllerComponent_Template : ActorComponent_Template {
		public bool useCircle;
		public bool useBox;
		public float minRange;
		public float maxRange;
		public Color minColor;
		public Color maxColor;
		public AABB boxShape;
		public bool inactiveWhenOutOfRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useCircle = s.Serialize<bool>(useCircle, name: "useCircle");
			useBox = s.Serialize<bool>(useBox, name: "useBox");
			minRange = s.Serialize<float>(minRange, name: "minRange");
			maxRange = s.Serialize<float>(maxRange, name: "maxRange");
			minColor = s.SerializeObject<Color>(minColor, name: "minColor");
			maxColor = s.SerializeObject<Color>(maxColor, name: "maxColor");
			boxShape = s.SerializeObject<AABB>(boxShape, name: "boxShape");
			inactiveWhenOutOfRange = s.Serialize<bool>(inactiveWhenOutOfRange, name: "inactiveWhenOutOfRange");
		}
		public override uint? ClassCRC => 0x6DDC713D;
	}
}

