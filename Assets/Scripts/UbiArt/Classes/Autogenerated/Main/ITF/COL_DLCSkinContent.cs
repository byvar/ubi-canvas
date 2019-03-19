using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCSkinContent : CSerializable {
		[Serialize("feedbacksTemplatePath")] public Path feedbacksTemplatePath;
		[Serialize("actor"                )] public string actor;
		[Serialize("skinFamily"           )] public StringID skinFamily;
		[Serialize("skin"                 )] public StringID skin;
		[Serialize("hairFeedback"         )] public StringID hairFeedback;
		[Serialize("name"                 )] public Placeholder name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(feedbacksTemplatePath));
			SerializeField(s, nameof(actor));
			SerializeField(s, nameof(skinFamily));
			SerializeField(s, nameof(skin));
			SerializeField(s, nameof(hairFeedback));
			SerializeField(s, nameof(name));
		}
		public override uint? ClassCRC => 0x73B9A851;
	}
}

