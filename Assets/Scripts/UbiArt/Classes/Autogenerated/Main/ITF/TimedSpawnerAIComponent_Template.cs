using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TimedSpawnerAIComponent_Template : AIComponent_Template {
		[Serialize("disableBehavior"                          )] public Generic<TemplateAIBehavior> disableBehavior;
		[Serialize("activateBehavior"                         )] public Generic<TemplateAIBehavior> activateBehavior;
		[Serialize("anticipateBehavior"                       )] public Generic<TemplateAIBehavior> anticipateBehavior;
		[Serialize("spawnBehavior"                            )] public Generic<TemplateAIBehavior> spawnBehavior;
		[Serialize("receiveHitBehavior"                       )] public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"                            )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("timedSpawner"                             )] public TimedSpawnerComponent_Template timedSpawner;
		[Serialize("anticipateDuration"                       )] public float anticipateDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(disableBehavior));
			SerializeField(s, nameof(activateBehavior));
			SerializeField(s, nameof(anticipateBehavior));
			SerializeField(s, nameof(spawnBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(timedSpawner));
			SerializeField(s, nameof(anticipateDuration));
		}
		public override uint? ClassCRC => 0xA226BD33;
	}
}

