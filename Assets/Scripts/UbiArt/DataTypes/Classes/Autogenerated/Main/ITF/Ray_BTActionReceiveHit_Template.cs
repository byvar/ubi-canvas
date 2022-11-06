using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionReceiveHit_Template : BTAction_Template {
		public StringID anim;
		public float punchFrontWeakForce;
		public float punchFrontStrongForce;
		public float punchFrontMegaForce;
		public float punchFrontWeakFrictionMult;
		public float punchFrontStrongFrictionMult;
		public float punchFrontMegaFrictionMult;
		public float punchFrontWeakTime;
		public float punchFrontStrongTime;
		public float punchFrontMegaTime;
		public float punchUpWeakForce;
		public float punchUpStrongForce;
		public float punchUpMegaForce;
		public float punchUpWeakGravityMultiplier;
		public float punchUpStrongGravityMultiplier;
		public float punchUpMegaGravityMultiplier;
		public float earthquakeWeakForce;
		public float earthquakeStrongForce;
		public float earthquakeMegaForce;
		public float bounceVWeakForce;
		public float bounceVStrongForce;
		public float bounceVMegaForce;
		public float bounceHWeakForce;
		public float bounceHStrongForce;
		public float bounceHMegaForce;
		public float bounceWeakTime;
		public float bounceStrongTime;
		public float bounceMegaTime;
		public float bounceWeakFrictionMultiplier;
		public float bounceStrongFrictionMultiplier;
		public float bounceMegaFrictionMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			punchFrontWeakForce = s.Serialize<float>(punchFrontWeakForce, name: "punchFrontWeakForce");
			punchFrontStrongForce = s.Serialize<float>(punchFrontStrongForce, name: "punchFrontStrongForce");
			punchFrontMegaForce = s.Serialize<float>(punchFrontMegaForce, name: "punchFrontMegaForce");
			punchFrontWeakFrictionMult = s.Serialize<float>(punchFrontWeakFrictionMult, name: "punchFrontWeakFrictionMult");
			punchFrontStrongFrictionMult = s.Serialize<float>(punchFrontStrongFrictionMult, name: "punchFrontStrongFrictionMult");
			punchFrontMegaFrictionMult = s.Serialize<float>(punchFrontMegaFrictionMult, name: "punchFrontMegaFrictionMult");
			punchFrontWeakTime = s.Serialize<float>(punchFrontWeakTime, name: "punchFrontWeakTime");
			punchFrontStrongTime = s.Serialize<float>(punchFrontStrongTime, name: "punchFrontStrongTime");
			punchFrontMegaTime = s.Serialize<float>(punchFrontMegaTime, name: "punchFrontMegaTime");
			punchUpWeakForce = s.Serialize<float>(punchUpWeakForce, name: "punchUpWeakForce");
			punchUpStrongForce = s.Serialize<float>(punchUpStrongForce, name: "punchUpStrongForce");
			punchUpMegaForce = s.Serialize<float>(punchUpMegaForce, name: "punchUpMegaForce");
			punchUpWeakGravityMultiplier = s.Serialize<float>(punchUpWeakGravityMultiplier, name: "punchUpWeakGravityMultiplier");
			punchUpStrongGravityMultiplier = s.Serialize<float>(punchUpStrongGravityMultiplier, name: "punchUpStrongGravityMultiplier");
			punchUpMegaGravityMultiplier = s.Serialize<float>(punchUpMegaGravityMultiplier, name: "punchUpMegaGravityMultiplier");
			earthquakeWeakForce = s.Serialize<float>(earthquakeWeakForce, name: "earthquakeWeakForce");
			earthquakeStrongForce = s.Serialize<float>(earthquakeStrongForce, name: "earthquakeStrongForce");
			earthquakeMegaForce = s.Serialize<float>(earthquakeMegaForce, name: "earthquakeMegaForce");
			bounceVWeakForce = s.Serialize<float>(bounceVWeakForce, name: "bounceVWeakForce");
			bounceVStrongForce = s.Serialize<float>(bounceVStrongForce, name: "bounceVStrongForce");
			bounceVMegaForce = s.Serialize<float>(bounceVMegaForce, name: "bounceVMegaForce");
			bounceHWeakForce = s.Serialize<float>(bounceHWeakForce, name: "bounceHWeakForce");
			bounceHStrongForce = s.Serialize<float>(bounceHStrongForce, name: "bounceHStrongForce");
			bounceHMegaForce = s.Serialize<float>(bounceHMegaForce, name: "bounceHMegaForce");
			bounceWeakTime = s.Serialize<float>(bounceWeakTime, name: "bounceWeakTime");
			bounceStrongTime = s.Serialize<float>(bounceStrongTime, name: "bounceStrongTime");
			bounceMegaTime = s.Serialize<float>(bounceMegaTime, name: "bounceMegaTime");
			bounceWeakFrictionMultiplier = s.Serialize<float>(bounceWeakFrictionMultiplier, name: "bounceWeakFrictionMultiplier");
			bounceStrongFrictionMultiplier = s.Serialize<float>(bounceStrongFrictionMultiplier, name: "bounceStrongFrictionMultiplier");
			bounceMegaFrictionMultiplier = s.Serialize<float>(bounceMegaFrictionMultiplier, name: "bounceMegaFrictionMultiplier");
		}
		public override uint? ClassCRC => 0x0639A728;
	}
}

