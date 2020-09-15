using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionReceiveHit_Template : BTAction_Template {
		[Serialize("anim"                          )] public StringID anim;
		[Serialize("fxStilts1"                     )] public StringID fxStilts1;
		[Serialize("fxStilts2"                     )] public StringID fxStilts2;
		[Serialize("fxStilts3"                     )] public StringID fxStilts3;
		[Serialize("fxStiltsOffset1"               )] public Vec2d fxStiltsOffset1;
		[Serialize("fxStiltsOffset2"               )] public Vec2d fxStiltsOffset2;
		[Serialize("fxStiltsOffset3"               )] public Vec2d fxStiltsOffset3;
		[Serialize("punchFrontWeakForceUp"         )] public float punchFrontWeakForceUp;
		[Serialize("punchFrontStrongForceUp"       )] public float punchFrontStrongForceUp;
		[Serialize("punchFrontMegaForceUp"         )] public float punchFrontMegaForceUp;
		[Serialize("punchFrontWeakForce"           )] public float punchFrontWeakForce;
		[Serialize("punchFrontStrongForce"         )] public float punchFrontStrongForce;
		[Serialize("punchFrontMegaForce"           )] public float punchFrontMegaForce;
		[Serialize("punchFrontWeakFrictionMult"    )] public float punchFrontWeakFrictionMult;
		[Serialize("punchFrontStrongFrictionMult"  )] public float punchFrontStrongFrictionMult;
		[Serialize("punchFrontMegaFrictionMult"    )] public float punchFrontMegaFrictionMult;
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
		[Serialize("faceHitDir"                    )] public bool faceHitDir;
		[Serialize("minHitLevelForDomino"          )] public uint minHitLevelForDomino;
		[Serialize("facteurBreakSpeedDomino"       )] public float facteurBreakSpeedDomino;
		[Serialize("useDominoEffect"               )] public bool useDominoEffect;
		[Serialize("canDoWallHit"                  )] public bool canDoWallHit;
		[Serialize("disablePhys"                   )] public bool disablePhys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(fxStilts1));
			SerializeField(s, nameof(fxStilts2));
			SerializeField(s, nameof(fxStilts3));
			SerializeField(s, nameof(fxStiltsOffset1));
			SerializeField(s, nameof(fxStiltsOffset2));
			SerializeField(s, nameof(fxStiltsOffset3));
			SerializeField(s, nameof(punchFrontWeakForceUp));
			SerializeField(s, nameof(punchFrontStrongForceUp));
			SerializeField(s, nameof(punchFrontMegaForceUp));
			SerializeField(s, nameof(punchFrontWeakForce));
			SerializeField(s, nameof(punchFrontStrongForce));
			SerializeField(s, nameof(punchFrontMegaForce));
			SerializeField(s, nameof(punchFrontWeakFrictionMult));
			SerializeField(s, nameof(punchFrontStrongFrictionMult));
			SerializeField(s, nameof(punchFrontMegaFrictionMult));
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
			SerializeField(s, nameof(faceHitDir));
			SerializeField(s, nameof(minHitLevelForDomino));
			SerializeField(s, nameof(facteurBreakSpeedDomino));
			SerializeField(s, nameof(useDominoEffect));
			SerializeField(s, nameof(canDoWallHit));
			SerializeField(s, nameof(disablePhys));
		}
		public override uint? ClassCRC => 0x4FE5F2FE;
	}
}

