using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionReceiveHit_Template : BTAction_Template {
		[Serialize("anim"                          )] public StringID anim;
		[Serialize("punchFrontWeakForce"           )] public float punchFrontWeakForce;
		[Serialize("punchFrontStrongForce"         )] public float punchFrontStrongForce;
		[Serialize("punchFrontMegaForce"           )] public float punchFrontMegaForce;
		[Serialize("punchFrontWeakFrictionMult"    )] public float punchFrontWeakFrictionMult;
		[Serialize("punchFrontStrongFrictionMult"  )] public float punchFrontStrongFrictionMult;
		[Serialize("punchFrontMegaFrictionMult"    )] public float punchFrontMegaFrictionMult;
		[Serialize("punchFrontWeakTime"            )] public float punchFrontWeakTime;
		[Serialize("punchFrontStrongTime"          )] public float punchFrontStrongTime;
		[Serialize("punchFrontMegaTime"            )] public float punchFrontMegaTime;
		[Serialize("punchUpWeakForce"              )] public float punchUpWeakForce;
		[Serialize("punchUpStrongForce"            )] public float punchUpStrongForce;
		[Serialize("punchUpMegaForce"              )] public float punchUpMegaForce;
		[Serialize("punchUpWeakGravityMultiplier"  )] public float punchUpWeakGravityMultiplier;
		[Serialize("punchUpStrongGravityMultiplier")] public float punchUpStrongGravityMultiplier;
		[Serialize("punchUpMegaGravityMultiplier"  )] public float punchUpMegaGravityMultiplier;
		[Serialize("earthquakeWeakForce"           )] public float earthquakeWeakForce;
		[Serialize("earthquakeStrongForce"         )] public float earthquakeStrongForce;
		[Serialize("earthquakeMegaForce"           )] public float earthquakeMegaForce;
		[Serialize("bounceVWeakForce"              )] public float bounceVWeakForce;
		[Serialize("bounceVStrongForce"            )] public float bounceVStrongForce;
		[Serialize("bounceVMegaForce"              )] public float bounceVMegaForce;
		[Serialize("bounceHWeakForce"              )] public float bounceHWeakForce;
		[Serialize("bounceHStrongForce"            )] public float bounceHStrongForce;
		[Serialize("bounceHMegaForce"              )] public float bounceHMegaForce;
		[Serialize("bounceWeakTime"                )] public float bounceWeakTime;
		[Serialize("bounceStrongTime"              )] public float bounceStrongTime;
		[Serialize("bounceMegaTime"                )] public float bounceMegaTime;
		[Serialize("bounceWeakFrictionMultiplier"  )] public float bounceWeakFrictionMultiplier;
		[Serialize("bounceStrongFrictionMultiplier")] public float bounceStrongFrictionMultiplier;
		[Serialize("bounceMegaFrictionMultiplier"  )] public float bounceMegaFrictionMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(punchFrontWeakForce));
			SerializeField(s, nameof(punchFrontStrongForce));
			SerializeField(s, nameof(punchFrontMegaForce));
			SerializeField(s, nameof(punchFrontWeakFrictionMult));
			SerializeField(s, nameof(punchFrontStrongFrictionMult));
			SerializeField(s, nameof(punchFrontMegaFrictionMult));
			SerializeField(s, nameof(punchFrontWeakTime));
			SerializeField(s, nameof(punchFrontStrongTime));
			SerializeField(s, nameof(punchFrontMegaTime));
			SerializeField(s, nameof(punchUpWeakForce));
			SerializeField(s, nameof(punchUpStrongForce));
			SerializeField(s, nameof(punchUpMegaForce));
			SerializeField(s, nameof(punchUpWeakGravityMultiplier));
			SerializeField(s, nameof(punchUpStrongGravityMultiplier));
			SerializeField(s, nameof(punchUpMegaGravityMultiplier));
			SerializeField(s, nameof(earthquakeWeakForce));
			SerializeField(s, nameof(earthquakeStrongForce));
			SerializeField(s, nameof(earthquakeMegaForce));
			SerializeField(s, nameof(bounceVWeakForce));
			SerializeField(s, nameof(bounceVStrongForce));
			SerializeField(s, nameof(bounceVMegaForce));
			SerializeField(s, nameof(bounceHWeakForce));
			SerializeField(s, nameof(bounceHStrongForce));
			SerializeField(s, nameof(bounceHMegaForce));
			SerializeField(s, nameof(bounceWeakTime));
			SerializeField(s, nameof(bounceStrongTime));
			SerializeField(s, nameof(bounceMegaTime));
			SerializeField(s, nameof(bounceWeakFrictionMultiplier));
			SerializeField(s, nameof(bounceStrongFrictionMultiplier));
			SerializeField(s, nameof(bounceMegaFrictionMultiplier));
		}
		public override uint? ClassCRC => 0x0639A728;
	}
}

