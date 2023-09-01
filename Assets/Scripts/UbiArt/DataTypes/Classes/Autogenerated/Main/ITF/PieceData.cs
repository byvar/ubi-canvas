namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class PieceData : CSerializable {
		public Path actorPath;
		public StringID name;
		public int detachOrder;
		public int startBhvUnderDamage;
		public StringID behaviorName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorPath = s.SerializeObject<Path>(actorPath, name: "actorPath");
			name = s.SerializeObject<StringID>(name, name: "name");
			detachOrder = s.Serialize<int>(detachOrder, name: "detachOrder");
			startBhvUnderDamage = s.Serialize<int>(startBhvUnderDamage, name: "startBhvUnderDamage");
			behaviorName = s.SerializeObject<StringID>(behaviorName, name: "behaviorName");
		}
	}
}

