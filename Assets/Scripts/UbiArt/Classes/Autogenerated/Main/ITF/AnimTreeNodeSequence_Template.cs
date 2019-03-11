using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodeSequence_Template : BlendTreeNodeBlend_Template<AnimTreeResult> {
		[Serialize("loopCount"         )] public int loopCount;
		[Serialize("randomizeLoopCount")] public bool randomizeLoopCount;
		[Serialize("randomLoopCountMax")] public uint randomLoopCountMax;
		[Serialize("randomLoopCountMin")] public uint randomLoopCountMin;
		[Serialize("nodeName"          )] public StringID nodeName;
		[Serialize("leafs"             )] public Placeholder leafs;
		[Serialize("ignoreRuleChanges" )] public bool ignoreRuleChanges;
		[Serialize("loopCount"         )] public bool loopCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(nodeName));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(leafs));
				}
				SerializeField(s, nameof(ignoreRuleChanges));
				SerializeField(s, nameof(loopCount));
				SerializeField(s, nameof(randomizeLoopCount));
				SerializeField(s, nameof(randomLoopCountMax));
				SerializeField(s, nameof(randomLoopCountMin));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(loopCount));
				SerializeField(s, nameof(randomizeLoopCount));
				SerializeField(s, nameof(randomLoopCountMax));
				SerializeField(s, nameof(randomLoopCountMin));
			} else {
				SerializeField(s, nameof(loopCount));
				SerializeField(s, nameof(randomizeLoopCount));
				SerializeField(s, nameof(randomLoopCountMax));
				SerializeField(s, nameof(randomLoopCountMin));
			}
		}
		public override uint? ClassCRC => 0x355CE175;
	}
}

