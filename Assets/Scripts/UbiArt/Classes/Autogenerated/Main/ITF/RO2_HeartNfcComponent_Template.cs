using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HeartNfcComponent_Template : ActorComponent_Template {
		public float zOffset;
		public float smooth;
		public float doubleSmooth;
		public float spiralCount;
		public float spiralAmplitude;
		public float targetReachedDistance;
		public float fadeOutDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			smooth = s.Serialize<float>(smooth, name: "smooth");
			doubleSmooth = s.Serialize<float>(doubleSmooth, name: "doubleSmooth");
			spiralCount = s.Serialize<float>(spiralCount, name: "spiralCount");
			spiralAmplitude = s.Serialize<float>(spiralAmplitude, name: "spiralAmplitude");
			targetReachedDistance = s.Serialize<float>(targetReachedDistance, name: "targetReachedDistance");
			fadeOutDuration = s.Serialize<float>(fadeOutDuration, name: "fadeOutDuration");
		}
		public override uint? ClassCRC => 0xFA935954;
	}
}

