using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AISleepBehavior_Template : TemplateAIBehavior {
		[Serialize("idle"             )] public Generic<AIAction_Template> idle;
		[Serialize("wakeUp"           )] public Generic<AIAction_Template> wakeUp;
		[Serialize("deactivatePhysics")] public int deactivatePhysics;
		[Serialize("wakeUpOnTrigger"  )] public int wakeUpOnTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(wakeUp));
			SerializeField(s, nameof(deactivatePhysics));
			SerializeField(s, nameof(wakeUpOnTrigger));
		}
		public override uint? ClassCRC => 0xD9DEB640;
	}
}

