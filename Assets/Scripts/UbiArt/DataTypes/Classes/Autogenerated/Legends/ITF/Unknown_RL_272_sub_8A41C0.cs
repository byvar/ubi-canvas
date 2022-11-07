namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_272_sub_8A41C0 : Event {
		public float teleportDuration;
		public ObjectPath targetActorPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			teleportDuration = s.Serialize<float>(teleportDuration, name: "teleportDuration");
			targetActorPath = s.SerializeObject<ObjectPath>(targetActorPath, name: "targetActorPath");
		}
		public override uint? ClassCRC => 0xC5BA7F3F;
	}
}

