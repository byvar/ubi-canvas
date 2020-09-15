using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CageMapAmbianceComponent_Template : ActorComponent_Template {
		public Color darkColor;
		public Color neutralColor;
		public Color lightColor;
		public float darkToNeutralTime;
		public float neutralToLightTime;
		public int startRank;
		public int renderRank;
		public float darkAlphaFadeTime;
		public float darkAlphaRadialProgressionSpeed;
		public float lightAlphaFadeTime;
		public float lightAlphaRadialProgressionSpeed;
		public AABB forcedAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			darkColor = s.SerializeObject<Color>(darkColor, name: "darkColor");
			neutralColor = s.SerializeObject<Color>(neutralColor, name: "neutralColor");
			lightColor = s.SerializeObject<Color>(lightColor, name: "lightColor");
			darkToNeutralTime = s.Serialize<float>(darkToNeutralTime, name: "darkToNeutralTime");
			neutralToLightTime = s.Serialize<float>(neutralToLightTime, name: "neutralToLightTime");
			startRank = s.Serialize<int>(startRank, name: "startRank");
			renderRank = s.Serialize<int>(renderRank, name: "renderRank");
			darkAlphaFadeTime = s.Serialize<float>(darkAlphaFadeTime, name: "darkAlphaFadeTime");
			darkAlphaRadialProgressionSpeed = s.Serialize<float>(darkAlphaRadialProgressionSpeed, name: "darkAlphaRadialProgressionSpeed");
			lightAlphaFadeTime = s.Serialize<float>(lightAlphaFadeTime, name: "lightAlphaFadeTime");
			lightAlphaRadialProgressionSpeed = s.Serialize<float>(lightAlphaRadialProgressionSpeed, name: "lightAlphaRadialProgressionSpeed");
			forcedAABB = s.SerializeObject<AABB>(forcedAABB, name: "forcedAABB");
		}
		public override uint? ClassCRC => 0x6E9D8E58;
	}
}

