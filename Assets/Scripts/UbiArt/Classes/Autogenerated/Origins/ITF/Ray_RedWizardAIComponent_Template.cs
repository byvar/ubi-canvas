using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_RedWizardAIComponent_Template : Ray_GroundAIComponent_Template {
		[Serialize("followDetectDistance"   )] public float followDetectDistance;
		[Serialize("followBehavior"         )] public Placeholder followBehavior;
		[Serialize("eventTriggeredBehaviors")] public Placeholder eventTriggeredBehaviors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(followDetectDistance));
			SerializeField(s, nameof(followBehavior));
			SerializeField(s, nameof(eventTriggeredBehaviors));
		}
		public override uint? ClassCRC => 0x08D139D7;
	}
}

