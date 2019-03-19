using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeBonusTextComponent_Template : ActorComponent_Template {
		[Serialize("rulesAnim"    )] public StringID rulesAnim;
		[Serialize("rulesHideAnim")] public StringID rulesHideAnim;
		[Serialize("looseAnim"    )] public StringID looseAnim;
		[Serialize("winAnim"      )] public StringID winAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rulesAnim));
			SerializeField(s, nameof(rulesHideAnim));
			SerializeField(s, nameof(looseAnim));
			SerializeField(s, nameof(winAnim));
		}
		public override uint? ClassCRC => 0xA5BF10DA;
	}
}

