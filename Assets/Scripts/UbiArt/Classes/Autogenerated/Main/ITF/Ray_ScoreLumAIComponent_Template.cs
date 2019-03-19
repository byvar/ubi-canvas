using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ScoreLumAIComponent_Template : Ray_FixedAIComponent_Template {
		[Serialize("lumAtlasPath"  )] public Path lumAtlasPath;
		[Serialize("framePerSecond")] public float framePerSecond;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lumAtlasPath));
			SerializeField(s, nameof(framePerSecond));
		}
		public override uint? ClassCRC => 0xDD5B1A63;
	}
}

