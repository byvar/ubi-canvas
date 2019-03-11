using UnityEngine;

namespace UbiArt.ITF {
	public partial class AISimplePlayAnimBehavior_Template : TemplateAIBehavior {
		[Serialize("playAnim")] public Generic<AIPlayAnimAction_Template> playAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playAnim));
		}
		public override uint? ClassCRC => 0xE1DF1C45;
	}
}

