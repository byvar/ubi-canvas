using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ScoreRecapRewardSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("rewardPath")] public Path rewardPath;
		[Serialize("snapBone"  )] public StringID snapBone;
		[Serialize("debug"     )] public bool debug;
		[Serialize("showAnim"  )] public StringID showAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rewardPath));
			SerializeField(s, nameof(snapBone));
			SerializeField(s, nameof(debug));
			SerializeField(s, nameof(showAnim));
		}
		public override uint? ClassCRC => 0xEFECE2BE;
	}
}

