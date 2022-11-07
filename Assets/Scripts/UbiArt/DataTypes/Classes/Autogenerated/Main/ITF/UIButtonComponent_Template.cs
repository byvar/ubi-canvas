namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIButtonComponent_Template : UIComponent_Template {
		public float speed;
		public Path path;
		public float idleSelectedScale;
		public float idleSelectedPulseFrequency;
		public int is2dActor;
		public float actorScaleSmoothFactor;
		public float minActorScale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
			path = s.SerializeObject<Path>(path, name: "path");
			idleSelectedScale = s.Serialize<float>(idleSelectedScale, name: "idleSelectedScale");
			idleSelectedPulseFrequency = s.Serialize<float>(idleSelectedPulseFrequency, name: "idleSelectedPulseFrequency");
			is2dActor = s.Serialize<int>(is2dActor, name: "is2dActor");
			actorScaleSmoothFactor = s.Serialize<float>(actorScaleSmoothFactor, name: "actorScaleSmoothFactor");
			minActorScale = s.Serialize<float>(minActorScale, name: "minActorScale");
		}
		public override uint? ClassCRC => 0x28D297A0;
	}
}

