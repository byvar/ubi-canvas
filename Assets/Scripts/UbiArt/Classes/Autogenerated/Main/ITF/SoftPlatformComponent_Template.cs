using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class SoftPlatformComponent_Template : ActorComponent_Template {
		[Serialize("softPlatformParticles"  )] public CList<SoftPlatformComponent_Template.BodyData> softPlatformParticles;
		[Serialize("softPlatformConstraints")] public CList<SoftPlatformComponent_Template.ConstraintData> softPlatformConstraints;
		[Serialize("weightMultiplier"       )] public float weightMultiplier;
		[Serialize("landSpeedMultiplier"    )] public float landSpeedMultiplier;
		[Serialize("hitForceMultiplier"     )] public float hitForceMultiplier;
		[Serialize("impulseMultiplier"      )] public float impulseMultiplier;
		[Serialize("movingPolylineForce"    )] public float movingPolylineForce;
		[Serialize("gameMaterial"           )] public Path gameMaterial;
		[Serialize("usePhantom"             )] public bool usePhantom;
		[Serialize("precision"              )] public ConstraintSolverIterationPrecision precision;
		[Serialize("usePhantom"             )] public int usePhantom;
		[Serialize("precision"              )] public Enum_precision precision;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(softPlatformParticles));
				SerializeField(s, nameof(softPlatformConstraints));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(movingPolylineForce));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(usePhantom));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(softPlatformParticles));
				SerializeField(s, nameof(softPlatformConstraints));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(movingPolylineForce));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(usePhantom));
				SerializeField(s, nameof(precision));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(movingPolylineForce));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(usePhantom));
				SerializeField(s, nameof(precision));
			} else {
				SerializeField(s, nameof(softPlatformParticles));
				SerializeField(s, nameof(softPlatformConstraints));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(movingPolylineForce));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(usePhantom));
				SerializeField(s, nameof(precision));
			}
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class BodyData : CSerializable {
			[Serialize("bone"             )] public string bone;
			[Serialize("static"           )] public bool _static;
			[Serialize("gravityMultiplier")] public float gravityMultiplier;
			[Serialize("windMultiplier"   )] public float windMultiplier;
			[Serialize("useStaticAngle"   )] public bool useStaticAngle;
			[Serialize("setAngle"         )] public Angle setAngle;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(bone));
				SerializeField(s, nameof(_static));
				SerializeField(s, nameof(gravityMultiplier));
				SerializeField(s, nameof(windMultiplier));
				SerializeField(s, nameof(useStaticAngle));
				SerializeField(s, nameof(setAngle));
			}
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class ConstraintData : CSerializable {
			[Serialize("bodyA"      )] public string bodyA;
			[Serialize("bodyB"      )] public string bodyB;
			[Serialize("minAngle"   )] public Angle minAngle;
			[Serialize("maxAngle"   )] public Angle maxAngle;
			[Serialize("minLength"  )] public float minLength;
			[Serialize("maxLength"  )] public float maxLength;
			[Serialize("stiff"      )] public float stiff;
			[Serialize("damp"       )] public float damp;
			[Serialize("limitAngle" )] public bool limitAngle;
			[Serialize("relaxLength")] public bool relaxLength;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(bodyA));
				SerializeField(s, nameof(bodyB));
				SerializeField(s, nameof(minAngle));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(minLength));
				SerializeField(s, nameof(maxLength));
				SerializeField(s, nameof(stiff));
				SerializeField(s, nameof(damp));
				SerializeField(s, nameof(limitAngle));
				SerializeField(s, nameof(relaxLength));
			}
		}
		public enum ConstraintSolverIterationPrecision {
			[Serialize("ConstraintSolverIterationPrecision_Low"   )] Low = 0,
			[Serialize("ConstraintSolverIterationPrecision_Medium")] Medium = 1,
			[Serialize("ConstraintSolverIterationPrecision_High"  )] High = 2,
		}
		public enum Enum_precision {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_precision {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x44047C07;
	}
}

