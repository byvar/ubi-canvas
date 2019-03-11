using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_LivingStoneAIComponent2_Template : CSerializable {
		[Serialize("spikyHat"           )] public bool spikyHat;
		[Serialize("spikyHatMaxDistance")] public float spikyHatMaxDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spikyHat));
			SerializeField(s, nameof(spikyHatMaxDistance));
		}
		public override uint? ClassCRC => 0xF3941F2E;
	}
}

