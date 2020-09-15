using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_FindCharlieComponent_Template : ActorComponent_Template {
		public Path TutorialAnimPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TutorialAnimPath = s.SerializeObject<Path>(TutorialAnimPath, name: "TutorialAnimPath");
		}
		public override uint? ClassCRC => 0x04D85661;
	}
}

