using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIUtensilTrapBehavior_Template : TemplateAIBehavior {
		[Serialize("stickOffset"            )] public float stickOffset;
		[Serialize("speed"                  )] public float speed;
		[Serialize("trapAction"             )] public Generic<AIAction_Template> trapAction;
		[Serialize("launchAction"           )] public Generic<AIAction_Template> launchAction;
		[Serialize("flyAction"              )] public Generic<AIAction_Template> flyAction;
		[Serialize("stickAction"            )] public Generic<AIAction_Template> stickAction;
		[Serialize("platformAction"         )] public Generic<AIAction_Template> platformAction;
		[Serialize("assignRewardToActivator")] public bool assignRewardToActivator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stickOffset));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(trapAction));
			SerializeField(s, nameof(launchAction));
			SerializeField(s, nameof(flyAction));
			SerializeField(s, nameof(stickAction));
			SerializeField(s, nameof(platformAction));
			SerializeField(s, nameof(assignRewardToActivator));
		}
		public override uint? ClassCRC => 0xBB74E226;
	}
}

