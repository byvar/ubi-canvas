namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class RopeHookComponent : ActorComponent {
		public TouchHandler touchHandler;
		public float torqueFriction;
		public float attachmentDetectionRadius;
		public float hookingSmoothFactor;
		public Vec2d hookOffset;
		public Angle angleOffset;
		public float angleSmoothingFactor;
		public float snapDist;
		public float float__0;
		public float float__1;
		public float float__2;
		public Vec2d Vector2__3;
		public Angle Angle__4;
		public float float__5;
		public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
				Angle__4 = s.SerializeObject<Angle>(Angle__4, name: "Angle__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
			} else {
				touchHandler = s.SerializeObject<TouchHandler>(touchHandler, name: "touchHandler");
				torqueFriction = s.Serialize<float>(torqueFriction, name: "torqueFriction");
				attachmentDetectionRadius = s.Serialize<float>(attachmentDetectionRadius, name: "attachmentDetectionRadius");
				hookingSmoothFactor = s.Serialize<float>(hookingSmoothFactor, name: "hookingSmoothFactor");
				hookOffset = s.SerializeObject<Vec2d>(hookOffset, name: "hookOffset");
				angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
				angleSmoothingFactor = s.Serialize<float>(angleSmoothingFactor, name: "angleSmoothingFactor");
				snapDist = s.Serialize<float>(snapDist, name: "snapDist");
			}
		}
		public override uint? ClassCRC => 0xB42762E7;
	}
}

