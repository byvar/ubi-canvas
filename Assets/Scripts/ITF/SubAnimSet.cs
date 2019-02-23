using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class SubAnimSet : BaseObject {
		[Serialize(0, "animPackage")] public AnimResourcePackage animPackage;
		[Serialize(1, "animations")] public Container<SubAnim_Template> animations;
		[Serialize(2, "redirectSymmetryPatches", game = Settings.Game.RL)] public Container<RedirectSymmetryPatch> redirectSymmetryPatches;

		public SubAnimSet(Reader reader) : base(reader) {
		}
	}
}
