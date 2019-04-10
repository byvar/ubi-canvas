using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion | GameFlags.RLVersion)]
	public partial class SubAnimSet : CSerializable {
		[Serialize("animPackage")] public AnimResourcePackage animPackage;
		[Serialize("animations" )] public CList<SubAnim_Template> animations;
		[Serialize("redirectSymmetryPatches")] public CList<RedirectSymmetryPatch> redirectSymmetryPatches;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPackage));
			SerializeField(s, nameof(animations));
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(redirectSymmetryPatches));
			}
		}
	}
}

