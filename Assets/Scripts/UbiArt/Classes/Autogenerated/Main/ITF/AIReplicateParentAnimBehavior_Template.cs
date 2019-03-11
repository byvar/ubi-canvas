using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIReplicateParentAnimBehavior_Template : TemplateAIBehavior {
		[Serialize("useParentBind")] public bool useParentBind;
		[Serialize("defaultAnim"  )] public StringID defaultAnim;
		[Serialize("animsToAvoid" )] public CList<StringID> animsToAvoid;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useParentBind));
			SerializeField(s, nameof(defaultAnim));
			SerializeField(s, nameof(animsToAvoid));
		}
		public override uint? ClassCRC => 0x445E5733;
	}
}

