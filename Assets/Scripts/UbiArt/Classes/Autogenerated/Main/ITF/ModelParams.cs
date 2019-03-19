using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ModelParams : CSerializable {
		[Serialize("id"                    )] public int id;
		[Serialize("targetRadius"          )] public float targetRadius;
		[Serialize("enemyDetectionRadius"  )] public float enemyDetectionRadius;
		[Serialize("maxSpeed"              )] public float maxSpeed;
		[Serialize("maxSpeedThreatened"    )] public float maxSpeedThreatened;
		[Serialize("predictionFactor"      )] public float predictionFactor;
		[Serialize("maxPredicitionDistance")] public float maxPredicitionDistance;
		[Serialize("offsetRadius"          )] public float offsetRadius;
		[Serialize("separationRadius"      )] public float separationRadius;
		[Serialize("separationForce"       )] public float separationForce;
		[Serialize("playerSeparationRadius")] public float playerSeparationRadius;
		[Serialize("playerSeparationForce" )] public float playerSeparationForce;
		[Serialize("groundSeparationRadius")] public float groundSeparationRadius;
		[Serialize("groundSeparationForce" )] public float groundSeparationForce;
		[Serialize("minWaitTime"           )] public float minWaitTime;
		[Serialize("maxWaitTime"           )] public float maxWaitTime;
		[Serialize("flock"                 )] public bool flock;
		[Serialize("linearBlendFactor"     )] public float linearBlendFactor;
		[Serialize("linearMidBlendFactor"  )] public float linearMidBlendFactor;
		[Serialize("linearTolerance"       )] public float linearTolerance;
		[Serialize("onHitFX"               )] public StringID onHitFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(targetRadius));
			SerializeField(s, nameof(enemyDetectionRadius));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(maxSpeedThreatened));
			SerializeField(s, nameof(predictionFactor));
			SerializeField(s, nameof(maxPredicitionDistance));
			SerializeField(s, nameof(offsetRadius));
			SerializeField(s, nameof(separationRadius));
			SerializeField(s, nameof(separationForce));
			SerializeField(s, nameof(playerSeparationRadius));
			SerializeField(s, nameof(playerSeparationForce));
			SerializeField(s, nameof(groundSeparationRadius));
			SerializeField(s, nameof(groundSeparationForce));
			SerializeField(s, nameof(minWaitTime));
			SerializeField(s, nameof(maxWaitTime));
			SerializeField(s, nameof(flock));
			SerializeField(s, nameof(linearBlendFactor));
			SerializeField(s, nameof(linearMidBlendFactor));
			SerializeField(s, nameof(linearTolerance));
			SerializeField(s, nameof(onHitFX));
		}
	}
}

