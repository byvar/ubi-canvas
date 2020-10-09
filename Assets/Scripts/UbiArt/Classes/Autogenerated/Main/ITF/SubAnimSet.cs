using UnityEngine;

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
			if ((Settings.s.game == Settings.Game.RL && !Settings.s.isCatchThemAll) || Settings.s.game == Settings.Game.COL) {
				redirectSymmetryPatches = s.SerializeObject<CListO<RedirectSymmetryPatch>>(redirectSymmetryPatches, name: "redirectSymmetryPatches");
			}
		}
	}
}

