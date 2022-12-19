namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TouchDetectorComponent : ShapeDetectorComponent {
		public bool checkTaps = true;
		public float tapTime = 0.5f;
		public uint tapSampleTolerance = 5;
		public uint numTaps = 1;
		public bool tapHold;
		public float swipeMinLength = 20f;
		public Angle swipeAngleTolerance;
		public bool swipeThrough = true;
		public bool blockOnSwipe = true;
		public bool bidirectional;
		public uint priority = 10;
		public Angle angleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			checkTaps = s.Serialize<bool>(checkTaps, name: "checkTaps");
			tapTime = s.Serialize<float>(tapTime, name: "tapTime");
			tapSampleTolerance = s.Serialize<uint>(tapSampleTolerance, name: "tapSampleTolerance");
			numTaps = s.Serialize<uint>(numTaps, name: "numTaps");
			tapHold = s.Serialize<bool>(tapHold, name: "tapHold");
			swipeMinLength = s.Serialize<float>(swipeMinLength, name: "swipeMinLength");
			swipeAngleTolerance = s.SerializeObject<Angle>(swipeAngleTolerance, name: "swipeAngleTolerance");
			swipeThrough = s.Serialize<bool>(swipeThrough, name: "swipeThrough");
			blockOnSwipe = s.Serialize<bool>(blockOnSwipe, name: "blockOnSwipe");
			bidirectional = s.Serialize<bool>(bidirectional, name: "bidirectional");
			priority = s.Serialize<uint>(priority, name: "priority");
			angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
		}
		public override uint? ClassCRC => 0x6D6E4E33;
	}
}

