using UnityEngine;

namespace UbiArt.ITF {
	public partial class CompetitionLevelInfo : CSerializable {
		[Serialize("level"           )] public StringID level;
		[Serialize("mode"            )] public uint mode;
		[Serialize("frequency"       )] public uint frequency;
		[Serialize("objective"       )] public float objective;
		[Serialize("score_validation")] public float score_validation;
		[Serialize("isg"             )] public PathRef isg;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(level));
			SerializeField(s, nameof(mode));
			SerializeField(s, nameof(frequency));
			SerializeField(s, nameof(objective));
			SerializeField(s, nameof(score_validation));
			SerializeField(s, nameof(isg));
		}
	}
}

