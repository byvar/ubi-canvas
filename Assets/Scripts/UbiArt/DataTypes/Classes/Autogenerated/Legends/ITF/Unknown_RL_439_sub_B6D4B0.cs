namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_439_sub_B6D4B0 : ActorComponent_Template {
		public StringID animOpening;
		public StringID animOpen;
		public StringID animClosing;
		public StringID animClosed;
		public StringID animLocked;
		public Path actorCounterPath;
		public Vec2d counterOffset;
		public Path actorNewIconPath;
		public Vec2d newIconOffset;
		public Vec3d walkThroughDoorTarget;
		public Color enterColor;
		public float walkOutDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animOpening = s.SerializeObject<StringID>(animOpening, name: "animOpening");
			animOpen = s.SerializeObject<StringID>(animOpen, name: "animOpen");
			animClosing = s.SerializeObject<StringID>(animClosing, name: "animClosing");
			animClosed = s.SerializeObject<StringID>(animClosed, name: "animClosed");
			animLocked = s.SerializeObject<StringID>(animLocked, name: "animLocked");
			actorCounterPath = s.SerializeObject<Path>(actorCounterPath, name: "actorCounterPath");
			counterOffset = s.SerializeObject<Vec2d>(counterOffset, name: "counterOffset");
			actorNewIconPath = s.SerializeObject<Path>(actorNewIconPath, name: "actorNewIconPath");
			newIconOffset = s.SerializeObject<Vec2d>(newIconOffset, name: "newIconOffset");
			walkThroughDoorTarget = s.SerializeObject<Vec3d>(walkThroughDoorTarget, name: "walkThroughDoorTarget");
			enterColor = s.SerializeObject<Color>(enterColor, name: "enterColor");
			walkOutDistance = s.Serialize<float>(walkOutDistance, name: "walkOutDistance");
		}
		public override uint? ClassCRC => 0x4E818C41;
	}
}

