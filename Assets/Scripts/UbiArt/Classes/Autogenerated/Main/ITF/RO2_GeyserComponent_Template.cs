using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GeyserComponent_Template : RO2_ChildLaunchComponent_Template {
		public float warnDuration;
		public float launchDuration;
		public StringID launchCameraShake;
		public Path warnFx;
		public Vec3d warnFxOffset;
		public Path launchFx;
		public Vec3d launchFxOffset;
		public StringID idleAnim;
		public StringID warnAnim;
		public StringID launchAnim;
		public StringID doneAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			warnDuration = s.Serialize<float>(warnDuration, name: "warnDuration");
			launchDuration = s.Serialize<float>(launchDuration, name: "launchDuration");
			launchCameraShake = s.SerializeObject<StringID>(launchCameraShake, name: "launchCameraShake");
			warnFx = s.SerializeObject<Path>(warnFx, name: "warnFx");
			warnFxOffset = s.SerializeObject<Vec3d>(warnFxOffset, name: "warnFxOffset");
			launchFx = s.SerializeObject<Path>(launchFx, name: "launchFx");
			launchFxOffset = s.SerializeObject<Vec3d>(launchFxOffset, name: "launchFxOffset");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			warnAnim = s.SerializeObject<StringID>(warnAnim, name: "warnAnim");
			launchAnim = s.SerializeObject<StringID>(launchAnim, name: "launchAnim");
			doneAnim = s.SerializeObject<StringID>(doneAnim, name: "doneAnim");
		}
		public override uint? ClassCRC => 0x38A1A249;
	}
}

