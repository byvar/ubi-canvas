using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BulletAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("launchBehavior"        )] public Generic<TemplateAIBehavior> launchBehavior;
		[Serialize("genericBehavior"       )] public Generic<TemplateAIBehavior> genericBehavior;
		[Serialize("deathBehavior"         )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("deathNoStimBehavior"   )] public Generic<TemplateAIBehavior> deathNoStimBehavior;
		[Serialize("speed"                 )] public float speed;
		[Serialize("lifeTime"              )] public float lifeTime;
		[Serialize("collideWithEnvironment")] public int collideWithEnvironment;
		[Serialize("collideWithPhantoms"   )] public int collideWithPhantoms;
		[Serialize("activateNoCollDuration")] public float activateNoCollDuration;
		[Serialize("sendDeathStim"         )] public int sendDeathStim;
		[Serialize("isCameraRelative"      )] public int isCameraRelative;
		[Serialize("collideWithSolidEdges" )] public int collideWithSolidEdges;
		[Serialize("disablePolylineOnDeath")] public int disablePolylineOnDeath;
		[Serialize("destroyOnExitScreen"   )] public int destroyOnExitScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(launchBehavior));
			SerializeField(s, nameof(genericBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(deathNoStimBehavior));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(lifeTime));
			SerializeField(s, nameof(collideWithEnvironment));
			SerializeField(s, nameof(collideWithPhantoms));
			SerializeField(s, nameof(activateNoCollDuration));
			SerializeField(s, nameof(sendDeathStim));
			SerializeField(s, nameof(isCameraRelative));
			SerializeField(s, nameof(collideWithSolidEdges));
			SerializeField(s, nameof(disablePolylineOnDeath));
			SerializeField(s, nameof(destroyOnExitScreen));
			SerializeField(s, nameof(destroyOnExitScreen));
		}
		public override uint? ClassCRC => 0x18FDE236;
	}
}

