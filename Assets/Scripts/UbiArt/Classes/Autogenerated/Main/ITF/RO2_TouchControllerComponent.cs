using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchControllerComponent : ActorComponent {
		[Serialize("duration"                )] public float duration;
		[Serialize("swipe"                   )] public bool swipe;
		[Serialize("swipeDirection"          )] public Vector2 swipeDirection;
		[Serialize("swipeAngleTolerance"     )] public Angle swipeAngleTolerance;
		[Serialize("swipeMinLength"          )] public float swipeMinLength;
		[Serialize("swipeThrough"            )] public bool swipeThrough;
		[Serialize("instructionForward"      )] public StringID instructionForward;
		[Serialize("instructionBackward"     )] public StringID instructionBackward;
		[Serialize("relativeMode"            )] public bool relativeMode;
		[Serialize("screenSpaceMode"         )] public bool screenSpaceMode;
		[Serialize("screenSpaceBeginPos"     )] public Vector2 screenSpaceBeginPos;
		[Serialize("screenSpaceEndPos"       )] public Vector2 screenSpaceEndPos;
		[Serialize("forward"                 )] public bool forward;
		[Serialize("cursorInitPos"           )] public float cursorInitPos;
		[Serialize("returnToInitPos"         )] public bool returnToInitPos;
		[Serialize("cursorSmooth"            )] public float cursorSmooth;
		[Serialize("cursorTargetSmooth"      )] public float cursorTargetSmooth;
		[Serialize("cursorReturnSmooth"      )] public float cursorReturnSmooth;
		[Serialize("cursorTargetReturnSmooth")] public float cursorTargetReturnSmooth;
		[Serialize("priority"                )] public uint priority;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(swipe));
			SerializeField(s, nameof(swipeDirection));
			SerializeField(s, nameof(swipeAngleTolerance));
			SerializeField(s, nameof(swipeMinLength));
			SerializeField(s, nameof(swipeThrough));
			SerializeField(s, nameof(instructionForward));
			SerializeField(s, nameof(instructionBackward));
			SerializeField(s, nameof(relativeMode));
			SerializeField(s, nameof(screenSpaceMode));
			SerializeField(s, nameof(screenSpaceBeginPos));
			SerializeField(s, nameof(screenSpaceEndPos));
			SerializeField(s, nameof(forward));
			SerializeField(s, nameof(cursorInitPos));
			SerializeField(s, nameof(returnToInitPos));
			SerializeField(s, nameof(cursorSmooth));
			SerializeField(s, nameof(cursorTargetSmooth));
			SerializeField(s, nameof(cursorReturnSmooth));
			SerializeField(s, nameof(cursorTargetReturnSmooth));
			SerializeField(s, nameof(priority));
		}
		public override uint? ClassCRC => 0x7DE15359;
	}
}

