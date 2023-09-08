namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class DialogActorComponent_Template : ActorComponent_Template {
		public Path balloonPath;
		public Path balloon3DPath;
		public StringID actorSnapBone;
		public float widthTextAreaMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				balloonPath = s.SerializeObject<Path>(balloonPath, name: "balloonPath");
				balloon3DPath = s.SerializeObject<Path>(balloon3DPath, name: "balloon3DPath");
				actorSnapBone = s.SerializeObject<StringID>(actorSnapBone, name: "actorSnapBone");
				widthTextAreaMax = s.Serialize<float>(widthTextAreaMax, name: "widthTextAreaMax");
			} else {
				balloonPath = s.SerializeObject<Path>(balloonPath, name: "balloonPath");
				balloon3DPath = s.SerializeObject<Path>(balloon3DPath, name: "balloon3DPath");
				actorSnapBone = s.SerializeObject<StringID>(actorSnapBone, name: "actorSnapBone");
			}
		}
		public override uint? ClassCRC => 0xFC758052;
	}
}

