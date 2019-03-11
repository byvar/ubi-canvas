using UnityEngine;

namespace UbiArt.ITF {
	public partial class SimpleAIComponent_Template : GenericAIComponent_Template {
		[Serialize("receiveHitBehavior")] public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"     )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("simpleAiType"      )] public SimpleAiType simpleAiType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(receiveHitBehavior));
				SerializeField(s, nameof(deathBehavior));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(receiveHitBehavior));
				SerializeField(s, nameof(deathBehavior));
				SerializeField(s, nameof(simpleAiType));
			} else {
				SerializeField(s, nameof(receiveHitBehavior));
				SerializeField(s, nameof(deathBehavior));
				SerializeField(s, nameof(simpleAiType));
			}
		}
		public enum SimpleAiType {
			[Serialize("simpleAiType_None" )] None = 0,
			[Serialize("simpleAiType_Punch")] Punch = 1,
		}
		public override uint? ClassCRC => 0x290E3BF3;
	}
}

