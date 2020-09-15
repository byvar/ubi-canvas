using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BabyPiranhaComponent_Template : CSerializable {
		public ITF_ParticleGenerator_Template particleGeneratorStand;
		public ITF_ParticleGenerator_Template particleGeneratorAttack;
		public Path texture;
		public float idleRadiusMin;
		public float idleRadiusMax;
		public float idleSpeedMin;
		public float idleSpeedMax;
		public float inertia;
		public float xLimitMultiplier;
		public float desyncRatio;
		public float minJumpTime;
		public float maxJumpTime;
		public float minJumpDst;
		public float maxJumpDst;
		public float minDiveTime;
		public float maxDiveTime;
		public float minDiveDst;
		public float maxDiveDst;
		public float minSpeed;
		public float maxSpeed;
		public float insideLen;
		public float attackSlowDown;
		public float dstFromSurface;
		public float pertubationFrequence;
		public float perturbationRadiusRatio;
		public float fruitInfluenceDistMin;
		public float fruitInfluenceDistMax;
		public float speedFractionWhenNearFruit;
		public float pirahnaRadius;
		public float yOffset;
		public int canGoInsideWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			particleGeneratorStand = s.SerializeObject<ITF_ParticleGenerator_Template>(particleGeneratorStand, name: "particleGeneratorStand");
			particleGeneratorAttack = s.SerializeObject<ITF_ParticleGenerator_Template>(particleGeneratorAttack, name: "particleGeneratorAttack");
			texture = s.SerializeObject<Path>(texture, name: "texture");
			idleRadiusMin = s.Serialize<float>(idleRadiusMin, name: "idleRadiusMin");
			idleRadiusMax = s.Serialize<float>(idleRadiusMax, name: "idleRadiusMax");
			idleSpeedMin = s.Serialize<float>(idleSpeedMin, name: "idleSpeedMin");
			idleSpeedMax = s.Serialize<float>(idleSpeedMax, name: "idleSpeedMax");
			inertia = s.Serialize<float>(inertia, name: "inertia");
			xLimitMultiplier = s.Serialize<float>(xLimitMultiplier, name: "xLimitMultiplier");
			desyncRatio = s.Serialize<float>(desyncRatio, name: "desyncRatio");
			minJumpTime = s.Serialize<float>(minJumpTime, name: "minJumpTime");
			maxJumpTime = s.Serialize<float>(maxJumpTime, name: "maxJumpTime");
			minJumpDst = s.Serialize<float>(minJumpDst, name: "minJumpDst");
			maxJumpDst = s.Serialize<float>(maxJumpDst, name: "maxJumpDst");
			minDiveTime = s.Serialize<float>(minDiveTime, name: "minDiveTime");
			maxDiveTime = s.Serialize<float>(maxDiveTime, name: "maxDiveTime");
			minDiveDst = s.Serialize<float>(minDiveDst, name: "minDiveDst");
			maxDiveDst = s.Serialize<float>(maxDiveDst, name: "maxDiveDst");
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			insideLen = s.Serialize<float>(insideLen, name: "insideLen");
			attackSlowDown = s.Serialize<float>(attackSlowDown, name: "attackSlowDown");
			dstFromSurface = s.Serialize<float>(dstFromSurface, name: "dstFromSurface");
			pertubationFrequence = s.Serialize<float>(pertubationFrequence, name: "pertubationFrequence");
			perturbationRadiusRatio = s.Serialize<float>(perturbationRadiusRatio, name: "perturbationRadiusRatio");
			fruitInfluenceDistMin = s.Serialize<float>(fruitInfluenceDistMin, name: "fruitInfluenceDistMin");
			fruitInfluenceDistMax = s.Serialize<float>(fruitInfluenceDistMax, name: "fruitInfluenceDistMax");
			speedFractionWhenNearFruit = s.Serialize<float>(speedFractionWhenNearFruit, name: "speedFractionWhenNearFruit");
			pirahnaRadius = s.Serialize<float>(pirahnaRadius, name: "pirahnaRadius");
			yOffset = s.Serialize<float>(yOffset, name: "yOffset");
			canGoInsideWater = s.Serialize<int>(canGoInsideWater, name: "canGoInsideWater");
		}
		public override uint? ClassCRC => 0xF381D3CB;
	}
}

