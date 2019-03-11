using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MusicScoreAIBranchComponent_Template : RO2_BezierBranchComponent_Template {
		[Serialize("openingSpeed"      )] public float openingSpeed;
		[Serialize("noteIntervalHeight")] public float noteIntervalHeight;
		[Serialize("openSound"         )] public StringID openSound;
		[Serialize("closeSound"        )] public StringID closeSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(openingSpeed));
			SerializeField(s, nameof(noteIntervalHeight));
			SerializeField(s, nameof(openSound));
			SerializeField(s, nameof(closeSound));
		}
		public override uint? ClassCRC => 0xF74BCCEB;
	}
}

