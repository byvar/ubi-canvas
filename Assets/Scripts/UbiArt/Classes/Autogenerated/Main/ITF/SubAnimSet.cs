using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion | GameFlags.RLVersion)]
	public partial class SubAnimSet : CSerializable {
		public AnimResourcePackage animPackage;
		public CList<SubAnim_Template> animations;
		public CList<RedirectSymmetryPatch> redirectSymmetryPatches;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPackage = s.SerializeObject<AnimResourcePackage>(animPackage, name: "animPackage");
			animations = s.SerializeObject<CList<SubAnim_Template>>(animations, name: "animations");
			if ((Settings.s.game == Settings.Game.RL && !Settings.s.isCatchThemAll) || Settings.s.game == Settings.Game.COL) {
				redirectSymmetryPatches = s.SerializeObject<CList<RedirectSymmetryPatch>>(redirectSymmetryPatches, name: "redirectSymmetryPatches");
			}
		}
	}
}

