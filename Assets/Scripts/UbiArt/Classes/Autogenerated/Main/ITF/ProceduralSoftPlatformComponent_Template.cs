using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class ProceduralSoftPlatformComponent_Template : GraphicComponent_Template {
		[Serialize("isSwing"                   )] public bool isSwing;
		[Serialize("isLiana"                   )] public bool isLiana;
		[Serialize("defaultEndPos"             )] public Vec3d defaultEndPos;
		[Serialize("edgeLength"                )] public float edgeLength;
		[Serialize("lengthFactor"              )] public float lengthFactor;
		[Serialize("bezierSampling"            )] public uint bezierSampling;
		[Serialize("inverseCurveRenderer"      )] public bool inverseCurveRenderer;
		[Serialize("beginTexture"              )] public Path beginTexture;
		[Serialize("endTexture"                )] public Path endTexture;
		[Serialize("beginMaterial"             )] public GFXMaterialSerializable beginMaterial;
		[Serialize("endMaterial"               )] public GFXMaterialSerializable endMaterial;
		[Serialize("bezierRenderer"            )] public BezierCurveRenderer_Template bezierRenderer;
		[Serialize("bezierZOffset"             )] public float bezierZOffset;
		[Serialize("beginTextureScale"         )] public Vec2d beginTextureScale;
		[Serialize("endTextureScale"           )] public Vec2d endTextureScale;
		[Serialize("gameMaterial"              )] public Path gameMaterial;
		[Serialize("movingPolyForce"           )] public float movingPolyForce;
		[Serialize("weightMultiplier"          )] public float weightMultiplier;
		[Serialize("landSpeedMultiplier"       )] public float landSpeedMultiplier;
		[Serialize("hitForceMultiplier"        )] public float hitForceMultiplier;
		[Serialize("impulseMultiplier"         )] public float impulseMultiplier;
		[Serialize("phantom"                   )] public bool phantom;
		[Serialize("oppositePhantom"           )] public bool oppositePhantom;
		[Serialize("bodyWindMultiplier"        )] public float bodyWindMultiplier;
		[Serialize("bodyGravityMultiplier"     )] public float bodyGravityMultiplier;
		[Serialize("constraintMinAngle"        )] public Angle constraintMinAngle;
		[Serialize("constraintMaxAngle"        )] public Angle constraintMaxAngle;
		[Serialize("constraintMinLength"       )] public float constraintMinLength;
		[Serialize("constraintMaxLength"       )] public float constraintMaxLength;
		[Serialize("constraintStiff"           )] public float constraintStiff;
		[Serialize("constraintDamp"            )] public float constraintDamp;
		[Serialize("constraintLimitAngle"      )] public bool constraintLimitAngle;
		[Serialize("constraintRelaxLength"     )] public bool constraintRelaxLength;
		[Serialize("precision"                 )] public ConstraintSolverIterationPrecision precision;
		[Serialize("maxSwingAngle"             )] public Angle maxSwingAngle;
		[Serialize("stiffSwingSpeedFriction"   )] public float stiffSwingSpeedFriction;
		[Serialize("nonStiffSwingSpeedFriction")] public float nonStiffSwingSpeedFriction;
		[Serialize("startingBone"              )] public StringID startingBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(isSwing));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(isLiana));
				SerializeField(s, nameof(movingPolyForce));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(phantom));
				SerializeField(s, nameof(bodyWindMultiplier));
				SerializeField(s, nameof(bodyGravityMultiplier));
				SerializeField(s, nameof(constraintMinAngle));
				SerializeField(s, nameof(constraintMaxAngle));
				SerializeField(s, nameof(constraintMinLength));
				SerializeField(s, nameof(constraintMaxLength));
				SerializeField(s, nameof(constraintStiff));
				SerializeField(s, nameof(constraintDamp));
				SerializeField(s, nameof(constraintLimitAngle));
				SerializeField(s, nameof(constraintRelaxLength));
				SerializeField(s, nameof(lengthFactor));
				SerializeField(s, nameof(edgeLength));
				SerializeField(s, nameof(bezierRenderer));
				SerializeField(s, nameof(beginTexture));
				SerializeField(s, nameof(endTexture));
				SerializeField(s, nameof(bezierSampling));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(isSwing));
				SerializeField(s, nameof(isLiana));
				SerializeField(s, nameof(defaultEndPos));
				SerializeField(s, nameof(edgeLength));
				SerializeField(s, nameof(lengthFactor));
				SerializeField(s, nameof(bezierSampling));
				SerializeField(s, nameof(inverseCurveRenderer));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(beginTexture));
					SerializeField(s, nameof(endTexture));
				}
				SerializeField(s, nameof(beginMaterial));
				SerializeField(s, nameof(endMaterial));
				SerializeField(s, nameof(bezierRenderer));
				SerializeField(s, nameof(bezierZOffset));
				SerializeField(s, nameof(beginTextureScale));
				SerializeField(s, nameof(endTextureScale));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(movingPolyForce));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(phantom));
				SerializeField(s, nameof(oppositePhantom));
				SerializeField(s, nameof(bodyWindMultiplier));
				SerializeField(s, nameof(bodyGravityMultiplier));
				SerializeField(s, nameof(constraintMinAngle));
				SerializeField(s, nameof(constraintMaxAngle));
				SerializeField(s, nameof(constraintMinLength));
				SerializeField(s, nameof(constraintMaxLength));
				SerializeField(s, nameof(constraintStiff));
				SerializeField(s, nameof(constraintDamp));
				SerializeField(s, nameof(constraintLimitAngle));
				SerializeField(s, nameof(constraintRelaxLength));
				SerializeField(s, nameof(precision));
				SerializeField(s, nameof(maxSwingAngle));
				SerializeField(s, nameof(stiffSwingSpeedFriction));
				SerializeField(s, nameof(nonStiffSwingSpeedFriction));
				SerializeField(s, nameof(startingBone));
			} else {
				SerializeField(s, nameof(isSwing));
				SerializeField(s, nameof(isLiana));
				SerializeField(s, nameof(defaultEndPos));
				SerializeField(s, nameof(edgeLength));
				SerializeField(s, nameof(lengthFactor));
				SerializeField(s, nameof(bezierSampling));
				SerializeField(s, nameof(inverseCurveRenderer));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(beginTexture));
					SerializeField(s, nameof(endTexture));
				}
				SerializeField(s, nameof(beginMaterial));
				SerializeField(s, nameof(endMaterial));
				SerializeField(s, nameof(bezierRenderer));
				SerializeField(s, nameof(bezierZOffset));
				SerializeField(s, nameof(beginTextureScale));
				SerializeField(s, nameof(endTextureScale));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(movingPolyForce));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(phantom));
				SerializeField(s, nameof(oppositePhantom));
				SerializeField(s, nameof(bodyWindMultiplier));
				SerializeField(s, nameof(bodyGravityMultiplier));
				SerializeField(s, nameof(constraintMinAngle));
				SerializeField(s, nameof(constraintMaxAngle));
				SerializeField(s, nameof(constraintMinLength));
				SerializeField(s, nameof(constraintMaxLength));
				SerializeField(s, nameof(constraintStiff));
				SerializeField(s, nameof(constraintDamp));
				SerializeField(s, nameof(constraintLimitAngle));
				SerializeField(s, nameof(constraintRelaxLength));
				SerializeField(s, nameof(precision));
				SerializeField(s, nameof(maxSwingAngle));
				SerializeField(s, nameof(stiffSwingSpeedFriction));
				SerializeField(s, nameof(nonStiffSwingSpeedFriction));
				SerializeField(s, nameof(startingBone));
			}
		}
		public enum ConstraintSolverIterationPrecision {
			[Serialize("ConstraintSolverIterationPrecision_Low"   )] Low = 0,
			[Serialize("ConstraintSolverIterationPrecision_Medium")] Medium = 1,
			[Serialize("ConstraintSolverIterationPrecision_High"  )] High = 2,
		}
		public override uint? ClassCRC => 0x90F63027;
	}
}

