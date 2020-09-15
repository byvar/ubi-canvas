using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class SimpleAIComponent_Template : GenericAIComponent_Template {
		public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public SimpleAiType simpleAiType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				receiveHitBehavior = s.SerializeObject<Generic<AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
				deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			} else {
				receiveHitBehavior = s.SerializeObject<Generic<AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
				deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
				simpleAiType = s.Serialize<SimpleAiType>(simpleAiType, name: "simpleAiType");
			}
		}
		public enum SimpleAiType {
			[Serialize("simpleAiType_None" )] None = 0,
			[Serialize("simpleAiType_Punch")] Punch = 1,
		}
		public override uint? ClassCRC => 0x290E3BF3;
	}
}

