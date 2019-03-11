using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_FindCharlieComponent_Template : ActorComponent_Template {
		[Serialize("TutorialAnimPath")] public Path TutorialAnimPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TutorialAnimPath));
		}
		public override uint? ClassCRC => 0x04D85661;
	}
}

