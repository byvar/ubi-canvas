using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TouchSpringPlatformBaseComponent : ActorComponent {
		[Serialize("saveOnCheckpoint"       )] public bool saveOnCheckpoint;
		[Serialize("touchDetectCooldown"    )] public uint touchDetectCooldown;
		[Serialize("speed"                  )] public float speed;
		[Serialize("bounce"                 )] public float bounce;
		[Serialize("smoothTarget"           )] public float smoothTarget;
		[Serialize("holdSpeed"              )] public float holdSpeed;
		[Serialize("holdBounce"             )] public float holdBounce;
		[Serialize("holdSmoothTarget"       )] public float holdSmoothTarget;
		[Serialize("move"                   )] public Generic<TouchSpringMoveBase> move;
		[Serialize("oneShotSwipe"           )] public bool oneShotSwipe;
		[Serialize("oneShotSwipeAxisMin"    )] public Angle oneShotSwipeAxisMin;
		[Serialize("oneShotSwipeAxisMax"    )] public Angle oneShotSwipeAxisMax;
		[Serialize("oneShotSwipeAngleToler" )] public Angle oneShotSwipeAngleToler;
		[Serialize("oneShotTap"             )] public bool oneShotTap;
		[Serialize("proceduralAnimMaxCursor")] public float proceduralAnimMaxCursor;
		[Serialize("shape"                  )] public EditableShape shape;
		[Serialize("moveSavedCurrentCursor" )] public float moveSavedCurrentCursor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(saveOnCheckpoint));
				SerializeField(s, nameof(touchDetectCooldown));
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(bounce));
				SerializeField(s, nameof(smoothTarget));
				SerializeField(s, nameof(holdSpeed));
				SerializeField(s, nameof(holdBounce));
				SerializeField(s, nameof(holdSmoothTarget));
				SerializeField(s, nameof(move));
				SerializeField(s, nameof(oneShotSwipe));
				SerializeField(s, nameof(oneShotSwipeAxisMin));
				SerializeField(s, nameof(oneShotSwipeAxisMax));
				SerializeField(s, nameof(oneShotSwipeAngleToler));
				SerializeField(s, nameof(oneShotTap));
				SerializeField(s, nameof(proceduralAnimMaxCursor));
				SerializeField(s, nameof(shape));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(moveSavedCurrentCursor));
			}
		}
		public override uint? ClassCRC => 0x151A8CB5;
	}
}

