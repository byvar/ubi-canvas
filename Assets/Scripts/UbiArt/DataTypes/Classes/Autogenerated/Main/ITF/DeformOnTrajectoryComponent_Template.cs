namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class DeformOnTrajectoryComponent_Template : ActorComponent_Template {
		public CListO<StringID> bones;
		public float sampleLength;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				bones = s.SerializeObject<CListO<StringID>>(bones, name: "bones");
			} else {
				bones = s.SerializeObject<CListO<StringID>>(bones, name: "bones");
				sampleLength = s.Serialize<float>(sampleLength, name: "sampleLength");
			}
		}
		public override uint? ClassCRC => 0xCDC7E469;
	}
}

