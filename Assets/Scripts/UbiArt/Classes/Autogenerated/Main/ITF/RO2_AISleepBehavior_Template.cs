using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AISleepBehavior_Template : TemplateAIBehavior {
		[Serialize("idle"             )] public Generic<AIAction_Template> idle;
		[Serialize("wakeUp"           )] public Generic<AIAction_Template> wakeUp;
		[Serialize("deactivatePhysics")] public bool deactivatePhysics;
		[Serialize("wakeUpOnTrigger"  )] public bool wakeUpOnTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(wakeUp));
			SerializeField(s, nameof(deactivatePhysics));
			SerializeField(s, nameof(wakeUpOnTrigger));
		}
		public override uint? ClassCRC => 0xD6B8A43F;
	}
}

