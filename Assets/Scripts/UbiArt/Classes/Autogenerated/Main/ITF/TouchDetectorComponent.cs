using UnityEngine;

namespace UbiArt.ITF {
	public partial class TouchDetectorComponent : ShapeDetectorComponent {
		[Serialize("checkTaps"          )] public bool checkTaps;
		[Serialize("tapTime"            )] public float tapTime;
		[Serialize("tapSampleTolerance" )] public uint tapSampleTolerance;
		[Serialize("numTaps"            )] public uint numTaps;
		[Serialize("tapHold"            )] public bool tapHold;
		[Serialize("swipeMinLength"     )] public float swipeMinLength;
		[Serialize("swipeAngleTolerance")] public Angle swipeAngleTolerance;
		[Serialize("swipeThrough"       )] public bool swipeThrough;
		[Serialize("blockOnSwipe"       )] public bool blockOnSwipe;
		[Serialize("bidirectional"      )] public bool bidirectional;
		[Serialize("priority"           )] public uint priority;
		[Serialize("angleOffset"        )] public Angle angleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(checkTaps));
			SerializeField(s, nameof(tapTime));
			SerializeField(s, nameof(tapSampleTolerance));
			SerializeField(s, nameof(numTaps));
			SerializeField(s, nameof(tapHold));
			SerializeField(s, nameof(swipeMinLength));
			SerializeField(s, nameof(swipeAngleTolerance));
			SerializeField(s, nameof(swipeThrough));
			SerializeField(s, nameof(blockOnSwipe));
			SerializeField(s, nameof(bidirectional));
			SerializeField(s, nameof(priority));
			SerializeField(s, nameof(angleOffset));
		}
		public override uint? ClassCRC => 0x6D6E4E33;
	}
}

