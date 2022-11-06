using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class CompetitionLevelInfo : CSerializable {
		public StringID level;
		public uint mode;
		public uint frequency;
		public float objective;
		public float score_validation;
		public PathRef isg;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			level = s.SerializeObject<StringID>(level, name: "level");
			mode = s.Serialize<uint>(mode, name: "mode");
			frequency = s.Serialize<uint>(frequency, name: "frequency");
			objective = s.Serialize<float>(objective, name: "objective");
			score_validation = s.Serialize<float>(score_validation, name: "score_validation");
			isg = s.SerializeObject<PathRef>(isg, name: "isg");
		}
	}
}

