using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BulletAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("launchBehavior"        )] public Placeholder launchBehavior;
		[Serialize("genericBehavior"       )] public Placeholder genericBehavior;
		[Serialize("deathBehavior"         )] public Placeholder deathBehavior;
		[Serialize("deathNoStimBehavior"   )] public Placeholder deathNoStimBehavior;
		[Serialize("speed"                 )] public float speed;
		[Serialize("lifeTime"              )] public float lifeTime;
		[Serialize("collideWithEnvironment")] public bool collideWithEnvironment;
		[Serialize("collideWithPhantoms"   )] public bool collideWithPhantoms;
		[Serialize("activateNoCollDuration")] public float activateNoCollDuration;
		[Serialize("sendDeathStim"         )] public bool sendDeathStim;
		[Serialize("isCameraRelative"      )] public bool isCameraRelative;
		[Serialize("collideWithSolidEdges" )] public bool collideWithSolidEdges;
		[Serialize("disablePolylineOnDeath")] public bool disablePolylineOnDeath;
		[Serialize("destroyOnExitScreen"   )] public bool destroyOnExitScreen;
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
		}
		public override uint? ClassCRC => 0x18FDE236;
	}
}

