using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbComponent_Template : CSerializable {
		public StringID FX_appearing;
		public StringID FX_disappearing;
		public StringID FX_fainting;
		public StringID FX_floating;
		public StringID FX_picked;
		public float floatingRangeFactor;
		public float lifeSpan;
		public float speed;
		public float timeBeforeFaint;
		public float timeBeforePickable;
		public float timeForOrbsToReachGauge;
		public float fluidFactor;
		public float fluidRadius;
		public float healthLevelPercentage;
		public float manaLevelPercentage;
		public Color healthOrbColor;
		public Color lightOrbColor;
		public Color manaOrbColor;
		public int magnetEnable;
		public float magnetDistance;
		public float magnetDistanceWithLightSphere;
		public float magnetDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			FX_appearing = s.SerializeObject<StringID>(FX_appearing, name: "FX_appearing");
			FX_disappearing = s.SerializeObject<StringID>(FX_disappearing, name: "FX_disappearing");
			FX_fainting = s.SerializeObject<StringID>(FX_fainting, name: "FX_fainting");
			FX_floating = s.SerializeObject<StringID>(FX_floating, name: "FX_floating");
			FX_picked = s.SerializeObject<StringID>(FX_picked, name: "FX_picked");
			floatingRangeFactor = s.Serialize<float>(floatingRangeFactor, name: "floatingRangeFactor");
			lifeSpan = s.Serialize<float>(lifeSpan, name: "lifeSpan");
			speed = s.Serialize<float>(speed, name: "speed");
			timeBeforeFaint = s.Serialize<float>(timeBeforeFaint, name: "timeBeforeFaint");
			timeBeforePickable = s.Serialize<float>(timeBeforePickable, name: "timeBeforePickable");
			timeForOrbsToReachGauge = s.Serialize<float>(timeForOrbsToReachGauge, name: "timeForOrbsToReachGauge");
			fluidFactor = s.Serialize<float>(fluidFactor, name: "fluidFactor");
			fluidRadius = s.Serialize<float>(fluidRadius, name: "fluidRadius");
			healthLevelPercentage = s.Serialize<float>(healthLevelPercentage, name: "healthLevelPercentage");
			manaLevelPercentage = s.Serialize<float>(manaLevelPercentage, name: "manaLevelPercentage");
			healthOrbColor = s.SerializeObject<Color>(healthOrbColor, name: "healthOrbColor");
			lightOrbColor = s.SerializeObject<Color>(lightOrbColor, name: "lightOrbColor");
			manaOrbColor = s.SerializeObject<Color>(manaOrbColor, name: "manaOrbColor");
			magnetEnable = s.Serialize<int>(magnetEnable, name: "magnetEnable");
			magnetDistance = s.Serialize<float>(magnetDistance, name: "magnetDistance");
			magnetDistanceWithLightSphere = s.Serialize<float>(magnetDistanceWithLightSphere, name: "magnetDistanceWithLightSphere");
			magnetDuration = s.Serialize<float>(magnetDuration, name: "magnetDuration");
		}
		public override uint? ClassCRC => 0xD8E5EC9D;
	}
}

