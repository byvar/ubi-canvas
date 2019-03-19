using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.COL)]
	public partial class TimedSpawnerAIComponent_Template : AIComponent_Template {
		[Serialize("disableBehavior"                          )] public Generic<TemplateAIBehavior> disableBehavior;
		[Serialize("activateBehavior"                         )] public Generic<TemplateAIBehavior> activateBehavior;
		[Serialize("anticipateBehavior"                       )] public Generic<TemplateAIBehavior> anticipateBehavior;
		[Serialize("spawnBehavior"                            )] public Generic<TemplateAIBehavior> spawnBehavior;
		[Serialize("receiveHitBehavior"                       )] public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"                            )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("timedSpawner"                             )] public TimedSpawnerComponent_Template timedSpawner;
		[Serialize("anticipateDuration"                       )] public float anticipateDuration;
		[Serialize("Generic<TemplateAIBehavior>__0"           )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__0;
		[Serialize("Generic<TemplateAIBehavior>__1"           )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__1;
		[Serialize("Generic<TemplateAIBehavior>__2"           )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__2;
		[Serialize("Generic<TemplateAIBehavior>__3"           )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__3;
		[Serialize("Generic<AIReceiveHitBehavior_Template>__4")] public Generic<AIReceiveHitBehavior_Template> Generic_AIReceiveHitBehavior_Template__4;
		[Serialize("Generic<TemplateAIBehavior>__5"           )] public Generic<TemplateAIBehavior> Generic_TemplateAIBehavior__5;
		[Serialize("float__6"                                 )] public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Generic_TemplateAIBehavior__0));
				SerializeField(s, nameof(Generic_TemplateAIBehavior__1));
				SerializeField(s, nameof(Generic_TemplateAIBehavior__2));
				SerializeField(s, nameof(Generic_TemplateAIBehavior__3));
				SerializeField(s, nameof(Generic_AIReceiveHitBehavior_Template__4));
				SerializeField(s, nameof(Generic_TemplateAIBehavior__5));
				SerializeField(s, nameof(float__6));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(disableBehavior));
				SerializeField(s, nameof(activateBehavior));
				SerializeField(s, nameof(anticipateBehavior));
				SerializeField(s, nameof(spawnBehavior));
				SerializeField(s, nameof(deathBehavior));
				SerializeField(s, nameof(anticipateDuration));
			} else {
				SerializeField(s, nameof(disableBehavior));
				SerializeField(s, nameof(activateBehavior));
				SerializeField(s, nameof(anticipateBehavior));
				SerializeField(s, nameof(spawnBehavior));
				SerializeField(s, nameof(receiveHitBehavior));
				SerializeField(s, nameof(deathBehavior));
				SerializeField(s, nameof(timedSpawner));
				SerializeField(s, nameof(anticipateDuration));
			}
		}
		public override uint? ClassCRC => 0xA226BD33;
	}
}

