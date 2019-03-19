using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbComponent_Template : CSerializable {
		[Serialize("FX_appearing"                 )] public StringID FX_appearing;
		[Serialize("FX_disappearing"              )] public StringID FX_disappearing;
		[Serialize("FX_fainting"                  )] public StringID FX_fainting;
		[Serialize("FX_floating"                  )] public StringID FX_floating;
		[Serialize("FX_picked"                    )] public StringID FX_picked;
		[Serialize("floatingRangeFactor"          )] public float floatingRangeFactor;
		[Serialize("lifeSpan"                     )] public float lifeSpan;
		[Serialize("speed"                        )] public float speed;
		[Serialize("timeBeforeFaint"              )] public float timeBeforeFaint;
		[Serialize("timeBeforePickable"           )] public float timeBeforePickable;
		[Serialize("timeForOrbsToReachGauge"      )] public float timeForOrbsToReachGauge;
		[Serialize("fluidFactor"                  )] public float fluidFactor;
		[Serialize("fluidRadius"                  )] public float fluidRadius;
		[Serialize("healthLevelPercentage"        )] public float healthLevelPercentage;
		[Serialize("manaLevelPercentage"          )] public float manaLevelPercentage;
		[Serialize("healthOrbColor"               )] public Color healthOrbColor;
		[Serialize("lightOrbColor"                )] public Color lightOrbColor;
		[Serialize("manaOrbColor"                 )] public Color manaOrbColor;
		[Serialize("magnetEnable"                 )] public int magnetEnable;
		[Serialize("magnetDistance"               )] public float magnetDistance;
		[Serialize("magnetDistanceWithLightSphere")] public float magnetDistanceWithLightSphere;
		[Serialize("magnetDuration"               )] public float magnetDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(FX_appearing));
			SerializeField(s, nameof(FX_disappearing));
			SerializeField(s, nameof(FX_fainting));
			SerializeField(s, nameof(FX_floating));
			SerializeField(s, nameof(FX_picked));
			SerializeField(s, nameof(floatingRangeFactor));
			SerializeField(s, nameof(lifeSpan));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(timeBeforeFaint));
			SerializeField(s, nameof(timeBeforePickable));
			SerializeField(s, nameof(timeForOrbsToReachGauge));
			SerializeField(s, nameof(fluidFactor));
			SerializeField(s, nameof(fluidRadius));
			SerializeField(s, nameof(healthLevelPercentage));
			SerializeField(s, nameof(manaLevelPercentage));
			SerializeField(s, nameof(healthOrbColor));
			SerializeField(s, nameof(lightOrbColor));
			SerializeField(s, nameof(manaOrbColor));
			SerializeField(s, nameof(magnetEnable));
			SerializeField(s, nameof(magnetDistance));
			SerializeField(s, nameof(magnetDistanceWithLightSphere));
			SerializeField(s, nameof(magnetDuration));
		}
		public override uint? ClassCRC => 0xD8E5EC9D;
	}
}

