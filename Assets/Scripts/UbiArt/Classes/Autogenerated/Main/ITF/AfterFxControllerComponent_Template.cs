using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH)]
	public partial class AfterFxControllerComponent_Template : ActorComponent_Template {
		[Serialize("useCircle"             )] public bool useCircle;
		[Serialize("useBox"                )] public bool useBox;
		[Serialize("minRange"              )] public float minRange;
		[Serialize("maxRange"              )] public float maxRange;
		[Serialize("minColor"              )] public Color minColor;
		[Serialize("maxColor"              )] public Color maxColor;
		[Serialize("boxShape"              )] public AABB boxShape;
		[Serialize("inactiveWhenOutOfRange")] public bool inactiveWhenOutOfRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useCircle));
			SerializeField(s, nameof(useBox));
			SerializeField(s, nameof(minRange));
			SerializeField(s, nameof(maxRange));
			SerializeField(s, nameof(minColor));
			SerializeField(s, nameof(maxColor));
			SerializeField(s, nameof(boxShape));
			SerializeField(s, nameof(inactiveWhenOutOfRange));
		}
		public override uint? ClassCRC => 0x6DDC713D;
	}
}

