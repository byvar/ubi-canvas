namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class SubAnimSet : CSerializable {
		public AnimResourcePackage animPackage;
		public CListO<SubAnim_Template> animations;
		public CListO<RedirectSymmetryPatch> redirectSymmetryPatches;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPackage = s.SerializeObject<AnimResourcePackage>(animPackage, name: "animPackage");
			animations = s.SerializeObject<CListO<SubAnim_Template>>(animations, name: "animations");
			if ((s.Settings.Game == Game.RL && s.Settings.Platform != GamePlatform.Vita) || s.Settings.Game == Game.COL) {
				redirectSymmetryPatches = s.SerializeObject<CListO<RedirectSymmetryPatch>>(redirectSymmetryPatches, name: "redirectSymmetryPatches");
			}
		}
	}
}

