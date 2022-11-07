namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchControllerComponent : ActorComponent {
		public float duration;
		public bool swipe;
		public Vec2d swipeDirection;
		public Angle swipeAngleTolerance;
		public float swipeMinLength;
		public bool swipeThrough;
		public StringID instructionForward;
		public StringID instructionBackward;
		public bool relativeMode;
		public bool screenSpaceMode;
		public Vec2d screenSpaceBeginPos;
		public Vec2d screenSpaceEndPos;
		public bool forward;
		public float cursorInitPos;
		public bool returnToInitPos;
		public float cursorSmooth;
		public float cursorTargetSmooth;
		public float cursorReturnSmooth;
		public float cursorTargetReturnSmooth;
		public uint priority;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.Serialize<float>(duration, name: "duration");
			swipe = s.Serialize<bool>(swipe, name: "swipe");
			swipeDirection = s.SerializeObject<Vec2d>(swipeDirection, name: "swipeDirection");
			swipeAngleTolerance = s.SerializeObject<Angle>(swipeAngleTolerance, name: "swipeAngleTolerance");
			swipeMinLength = s.Serialize<float>(swipeMinLength, name: "swipeMinLength");
			swipeThrough = s.Serialize<bool>(swipeThrough, name: "swipeThrough");
			instructionForward = s.SerializeObject<StringID>(instructionForward, name: "instructionForward");
			instructionBackward = s.SerializeObject<StringID>(instructionBackward, name: "instructionBackward");
			relativeMode = s.Serialize<bool>(relativeMode, name: "relativeMode");
			screenSpaceMode = s.Serialize<bool>(screenSpaceMode, name: "screenSpaceMode");
			screenSpaceBeginPos = s.SerializeObject<Vec2d>(screenSpaceBeginPos, name: "screenSpaceBeginPos");
			screenSpaceEndPos = s.SerializeObject<Vec2d>(screenSpaceEndPos, name: "screenSpaceEndPos");
			forward = s.Serialize<bool>(forward, name: "forward");
			cursorInitPos = s.Serialize<float>(cursorInitPos, name: "cursorInitPos");
			returnToInitPos = s.Serialize<bool>(returnToInitPos, name: "returnToInitPos");
			cursorSmooth = s.Serialize<float>(cursorSmooth, name: "cursorSmooth");
			cursorTargetSmooth = s.Serialize<float>(cursorTargetSmooth, name: "cursorTargetSmooth");
			cursorReturnSmooth = s.Serialize<float>(cursorReturnSmooth, name: "cursorReturnSmooth");
			cursorTargetReturnSmooth = s.Serialize<float>(cursorTargetReturnSmooth, name: "cursorTargetReturnSmooth");
			priority = s.Serialize<uint>(priority, name: "priority");
		}
		public override uint? ClassCRC => 0x7DE15359;
	}
}

