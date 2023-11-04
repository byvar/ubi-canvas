namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchSpringPlatformBaseComponent : ActorComponent {
		public bool saveOnCheckpoint = true;
		public uint touchDetectCooldown = 10;
		public float speed = 0.1f;
		public float bounce = 0.8f;
		public float smoothTarget = 0.1f;
		public float holdSpeed = 0.5f;
		public float holdBounce = 0.01f;
		public float holdSmoothTarget = 0.5f;
		public Generic<TouchSpringMoveBase> move;
		public bool oneShotSwipe;
		public Angle oneShotSwipeAxisMin;
		public Angle oneShotSwipeAxisMax = 3.141593f;
		public Angle oneShotSwipeAngleToler = 0.5235988f;
		public bool oneShotTap;
		public float proceduralAnimMaxCursor;
		public EditableShape shape;
		public float moveSavedCurrentCursor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					saveOnCheckpoint = s.Serialize<bool>(saveOnCheckpoint, name: "saveOnCheckpoint");
					touchDetectCooldown = s.Serialize<uint>(touchDetectCooldown, name: "touchDetectCooldown");
					speed = s.Serialize<float>(speed, name: "speed");
					bounce = s.Serialize<float>(bounce, name: "bounce");
					smoothTarget = s.Serialize<float>(smoothTarget, name: "smoothTarget");
					holdSpeed = s.Serialize<float>(holdSpeed, name: "holdSpeed");
					holdBounce = s.Serialize<float>(holdBounce, name: "holdBounce");
					holdSmoothTarget = s.Serialize<float>(holdSmoothTarget, name: "holdSmoothTarget");
					move = s.SerializeObject<Generic<TouchSpringMoveBase>>(move, name: "move");
					oneShotSwipe = s.Serialize<bool>(oneShotSwipe, name: "oneShotSwipe", options: CSerializerObject.Options.BoolAsByte);
					if (oneShotSwipe) {
						oneShotSwipeAxisMin = s.SerializeObject<Angle>(oneShotSwipeAxisMin, name: "oneShotSwipeAxisMin");
						oneShotSwipeAxisMax = s.SerializeObject<Angle>(oneShotSwipeAxisMax, name: "oneShotSwipeAxisMax");
						oneShotSwipeAngleToler = s.SerializeObject<Angle>(oneShotSwipeAngleToler, name: "oneShotSwipeAngleToler");
					} else {
						oneShotTap = s.Serialize<bool>(oneShotTap, name: "oneShotTap", options: CSerializerObject.Options.BoolAsByte);
					}
					proceduralAnimMaxCursor = s.Serialize<float>(proceduralAnimMaxCursor, name: "proceduralAnimMaxCursor");
					shape = s.SerializeObject<EditableShape>(shape, name: "shape");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					moveSavedCurrentCursor = s.Serialize<float>(moveSavedCurrentCursor, name: "moveSavedCurrentCursor");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					saveOnCheckpoint = s.Serialize<bool>(saveOnCheckpoint, name: "saveOnCheckpoint");
					touchDetectCooldown = s.Serialize<uint>(touchDetectCooldown, name: "touchDetectCooldown");
					speed = s.Serialize<float>(speed, name: "speed");
					bounce = s.Serialize<float>(bounce, name: "bounce");
					smoothTarget = s.Serialize<float>(smoothTarget, name: "smoothTarget");
					holdSpeed = s.Serialize<float>(holdSpeed, name: "holdSpeed");
					holdBounce = s.Serialize<float>(holdBounce, name: "holdBounce");
					holdSmoothTarget = s.Serialize<float>(holdSmoothTarget, name: "holdSmoothTarget");
					move = s.SerializeObject<Generic<TouchSpringMoveBase>>(move, name: "move");
					oneShotSwipe = s.Serialize<bool>(oneShotSwipe, name: "oneShotSwipe");
					if (oneShotSwipe) {
						oneShotSwipeAxisMin = s.SerializeObject<Angle>(oneShotSwipeAxisMin, name: "oneShotSwipeAxisMin");
						oneShotSwipeAxisMax = s.SerializeObject<Angle>(oneShotSwipeAxisMax, name: "oneShotSwipeAxisMax");
						oneShotSwipeAngleToler = s.SerializeObject<Angle>(oneShotSwipeAngleToler, name: "oneShotSwipeAngleToler");
					} else {
						oneShotTap = s.Serialize<bool>(oneShotTap, name: "oneShotTap");
					}
					proceduralAnimMaxCursor = s.Serialize<float>(proceduralAnimMaxCursor, name: "proceduralAnimMaxCursor");
					shape = s.SerializeObject<EditableShape>(shape, name: "shape");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					moveSavedCurrentCursor = s.Serialize<float>(moveSavedCurrentCursor, name: "moveSavedCurrentCursor");
				}
			}
		}
		public override uint? ClassCRC => 0x151A8CB5;
	}
}

