using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIShooterEjectedBehavior_Template : TemplateAIBehavior {
		[Serialize("ejectAction"             )] public Generic<AIAction_Template> ejectAction;
		[Serialize("destroyOnEjectActionsEnd")] public int destroyOnEjectActionsEnd;
		[Serialize("killOnEnd"               )] public int killOnEnd;
		[Serialize("hitNumber"               )] public uint hitNumber;
		[Serialize("hitNumberNextBhvName"    )] public StringID hitNumberNextBhvName;
		[Serialize("ejectActionNextBhvName"  )] public StringID ejectActionNextBhvName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ejectAction));
			SerializeField(s, nameof(destroyOnEjectActionsEnd));
			SerializeField(s, nameof(killOnEnd));
			SerializeField(s, nameof(hitNumber));
			SerializeField(s, nameof(hitNumberNextBhvName));
			SerializeField(s, nameof(ejectActionNextBhvName));
		}
		public override uint? ClassCRC => 0x73A788E8;
	}
}

