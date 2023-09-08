namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class SimpleAIComponent_Template : GenericAIComponent_Template {
		public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public SimpleAiType simpleAiType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
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

