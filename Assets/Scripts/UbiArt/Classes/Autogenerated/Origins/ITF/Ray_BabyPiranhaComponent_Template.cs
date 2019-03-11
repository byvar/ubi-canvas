using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BabyPiranhaComponent_Template : CSerializable {
		[Serialize("particleGeneratorStand"    )] public Placeholder particleGeneratorStand;
		[Serialize("particleGeneratorAttack"   )] public Placeholder particleGeneratorAttack;
		[Serialize("texture"                   )] public Path texture;
		[Serialize("idleRadiusMin"             )] public float idleRadiusMin;
		[Serialize("idleRadiusMax"             )] public float idleRadiusMax;
		[Serialize("idleSpeedMin"              )] public float idleSpeedMin;
		[Serialize("idleSpeedMax"              )] public float idleSpeedMax;
		[Serialize("inertia"                   )] public float inertia;
		[Serialize("xLimitMultiplier"          )] public float xLimitMultiplier;
		[Serialize("desyncRatio"               )] public float desyncRatio;
		[Serialize("minJumpTime"               )] public float minJumpTime;
		[Serialize("maxJumpTime"               )] public float maxJumpTime;
		[Serialize("minJumpDst"                )] public float minJumpDst;
		[Serialize("maxJumpDst"                )] public float maxJumpDst;
		[Serialize("minDiveTime"               )] public float minDiveTime;
		[Serialize("maxDiveTime"               )] public float maxDiveTime;
		[Serialize("minDiveDst"                )] public float minDiveDst;
		[Serialize("maxDiveDst"                )] public float maxDiveDst;
		[Serialize("minSpeed"                  )] public float minSpeed;
		[Serialize("maxSpeed"                  )] public float maxSpeed;
		[Serialize("insideLen"                 )] public float insideLen;
		[Serialize("attackSlowDown"            )] public float attackSlowDown;
		[Serialize("dstFromSurface"            )] public float dstFromSurface;
		[Serialize("pertubationFrequence"      )] public float pertubationFrequence;
		[Serialize("perturbationRadiusRatio"   )] public float perturbationRadiusRatio;
		[Serialize("fruitInfluenceDistMin"     )] public float fruitInfluenceDistMin;
		[Serialize("fruitInfluenceDistMax"     )] public float fruitInfluenceDistMax;
		[Serialize("speedFractionWhenNearFruit")] public float speedFractionWhenNearFruit;
		[Serialize("pirahnaRadius"             )] public float pirahnaRadius;
		[Serialize("yOffset"                   )] public float yOffset;
		[Serialize("canGoInsideWater"          )] public bool canGoInsideWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(particleGeneratorStand));
			SerializeField(s, nameof(particleGeneratorAttack));
			SerializeField(s, nameof(texture));
			SerializeField(s, nameof(idleRadiusMin));
			SerializeField(s, nameof(idleRadiusMax));
			SerializeField(s, nameof(idleSpeedMin));
			SerializeField(s, nameof(idleSpeedMax));
			SerializeField(s, nameof(inertia));
			SerializeField(s, nameof(xLimitMultiplier));
			SerializeField(s, nameof(desyncRatio));
			SerializeField(s, nameof(minJumpTime));
			SerializeField(s, nameof(maxJumpTime));
			SerializeField(s, nameof(minJumpDst));
			SerializeField(s, nameof(maxJumpDst));
			SerializeField(s, nameof(minDiveTime));
			SerializeField(s, nameof(maxDiveTime));
			SerializeField(s, nameof(minDiveDst));
			SerializeField(s, nameof(maxDiveDst));
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(insideLen));
			SerializeField(s, nameof(attackSlowDown));
			SerializeField(s, nameof(dstFromSurface));
			SerializeField(s, nameof(pertubationFrequence));
			SerializeField(s, nameof(perturbationRadiusRatio));
			SerializeField(s, nameof(fruitInfluenceDistMin));
			SerializeField(s, nameof(fruitInfluenceDistMax));
			SerializeField(s, nameof(speedFractionWhenNearFruit));
			SerializeField(s, nameof(pirahnaRadius));
			SerializeField(s, nameof(yOffset));
			SerializeField(s, nameof(canGoInsideWater));
		}
		public override uint? ClassCRC => 0xF381D3CB;
	}
}

