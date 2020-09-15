using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCSkinContent : CSerializable {
		public Path feedbacksTemplatePath;
		public string actor;
		public StringID skinFamily;
		public StringID skin;
		public StringID hairFeedback;
		public Placeholder name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			feedbacksTemplatePath = s.SerializeObject<Path>(feedbacksTemplatePath, name: "feedbacksTemplatePath");
			actor = s.Serialize<string>(actor, name: "actor");
			skinFamily = s.SerializeObject<StringID>(skinFamily, name: "skinFamily");
			skin = s.SerializeObject<StringID>(skin, name: "skin");
			hairFeedback = s.SerializeObject<StringID>(hairFeedback, name: "hairFeedback");
			name = s.SerializeObject<Placeholder>(name, name: "name");
		}
		public override uint? ClassCRC => 0x73B9A851;
	}
}

