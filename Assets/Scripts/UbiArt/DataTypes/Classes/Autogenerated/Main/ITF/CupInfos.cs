namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class CupInfos : CSerializable {
		public Path actorPath;
		public Path actorPath3D;
		public SmartLocId name;
		public Color color;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorPath = s.SerializeObject<Path>(actorPath, name: "actorPath");
			actorPath3D = s.SerializeObject<Path>(actorPath3D, name: "actorPath3D");
			name = s.SerializeObject<SmartLocId>(name, name: "name");
			color = s.SerializeObject<Color>(color, name: "color");
		}
	}
}

