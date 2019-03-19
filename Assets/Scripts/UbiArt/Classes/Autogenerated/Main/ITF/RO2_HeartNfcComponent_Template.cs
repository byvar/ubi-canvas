using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HeartNfcComponent_Template : ActorComponent_Template {
		[Serialize("zOffset"              )] public float zOffset;
		[Serialize("smooth"               )] public float smooth;
		[Serialize("doubleSmooth"         )] public float doubleSmooth;
		[Serialize("spiralCount"          )] public float spiralCount;
		[Serialize("spiralAmplitude"      )] public float spiralAmplitude;
		[Serialize("targetReachedDistance")] public float targetReachedDistance;
		[Serialize("fadeOutDuration"      )] public float fadeOutDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(smooth));
			SerializeField(s, nameof(doubleSmooth));
			SerializeField(s, nameof(spiralCount));
			SerializeField(s, nameof(spiralAmplitude));
			SerializeField(s, nameof(targetReachedDistance));
			SerializeField(s, nameof(fadeOutDuration));
		}
		public override uint? ClassCRC => 0xFA935954;
	}
}

