namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchSpringPlatformBaseComponent : ActorComponent {
		public bool saveOnCheckpoint;
		public uint touchDetectCooldown;
		public float speed;
		public float bounce;
		public float smoothTarget;
		public float holdSpeed;
		public float holdBounce;
		public float holdSmoothTarget;
		public Generic<TouchSpringMoveBase> move;
		public bool oneShotSwipe;
		public Angle oneShotSwipeAxisMin;
		public Angle oneShotSwipeAxisMax;
		public Angle oneShotSwipeAngleToler;
		public bool oneShotTap;
		public float proceduralAnimMaxCursor;
		public EditableShape shape;
		public float moveSavedCurrentCursor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
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

