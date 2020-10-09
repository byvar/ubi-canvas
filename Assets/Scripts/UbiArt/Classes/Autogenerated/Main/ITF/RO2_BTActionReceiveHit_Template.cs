using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionReceiveHit_Template : BTAction_Template {
		public StringID anim;
		public StringID fxStilts1;
		public StringID fxStilts2;
		public StringID fxStilts3;
		public Vec2d fxStiltsOffset1;
		public Vec2d fxStiltsOffset2;
		public Vec2d fxStiltsOffset3;
		public float punchFrontWeakForceUp;
		public float punchFrontStrongForceUp;
		public float punchFrontMegaForceUp;
		public float punchFrontWeakForce;
		public float punchFrontStrongForce;
		public float punchFrontMegaForce;
		public float punchFrontWeakFrictionMult;
		public float punchFrontStrongFrictionMult;
		public float punchFrontMegaFrictionMult;
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
		public bool faceHitDir;
		public uint minHitLevelForDomino;
		public float facteurBreakSpeedDomino;
		public bool useDominoEffect;
		public bool canDoWallHit;
		public bool disablePhys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			fxStilts1 = s.SerializeObject<StringID>(fxStilts1, name: "fxStilts1");
			fxStilts2 = s.SerializeObject<StringID>(fxStilts2, name: "fxStilts2");
			fxStilts3 = s.SerializeObject<StringID>(fxStilts3, name: "fxStilts3");
			fxStiltsOffset1 = s.SerializeObject<Vec2d>(fxStiltsOffset1, name: "fxStiltsOffset1");
			fxStiltsOffset2 = s.SerializeObject<Vec2d>(fxStiltsOffset2, name: "fxStiltsOffset2");
			fxStiltsOffset3 = s.SerializeObject<Vec2d>(fxStiltsOffset3, name: "fxStiltsOffset3");
			punchFrontWeakForceUp = s.Serialize<float>(punchFrontWeakForceUp, name: "punchFrontWeakForceUp");
			punchFrontStrongForceUp = s.Serialize<float>(punchFrontStrongForceUp, name: "punchFrontStrongForceUp");
			punchFrontMegaForceUp = s.Serialize<float>(punchFrontMegaForceUp, name: "punchFrontMegaForceUp");
			punchFrontWeakForce = s.Serialize<float>(punchFrontWeakForce, name: "punchFrontWeakForce");
			punchFrontStrongForce = s.Serialize<float>(punchFrontStrongForce, name: "punchFrontStrongForce");
			punchFrontMegaForce = s.Serialize<float>(punchFrontMegaForce, name: "punchFrontMegaForce");
			punchFrontWeakFrictionMult = s.Serialize<float>(punchFrontWeakFrictionMult, name: "punchFrontWeakFrictionMult");
			punchFrontStrongFrictionMult = s.Serialize<float>(punchFrontStrongFrictionMult, name: "punchFrontStrongFrictionMult");
			punchFrontMegaFrictionMult = s.Serialize<float>(punchFrontMegaFrictionMult, name: "punchFrontMegaFrictionMult");
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
			faceHitDir = s.Serialize<bool>(faceHitDir, name: "faceHitDir");
			minHitLevelForDomino = s.Serialize<uint>(minHitLevelForDomino, name: "minHitLevelForDomino");
			facteurBreakSpeedDomino = s.Serialize<float>(facteurBreakSpeedDomino, name: "facteurBreakSpeedDomino");
			useDominoEffect = s.Serialize<bool>(useDominoEffect, name: "useDominoEffect");
			canDoWallHit = s.Serialize<bool>(canDoWallHit, name: "canDoWallHit");
			disablePhys = s.Serialize<bool>(disablePhys, name: "disablePhys");
		}
		public override uint? ClassCRC => 0x4FE5F2FE;
	}
}

