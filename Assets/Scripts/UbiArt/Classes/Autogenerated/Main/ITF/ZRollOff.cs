using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion)]
	public partial class ZRollOff : SoundModifier {
		public float distanceMin;
		public float distanceMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			distanceMin = s.Serialize<float>(distanceMin, name: "distanceMin");
			distanceMax = s.Serialize<float>(distanceMax, name: "distanceMax");
		}
		public override uint? ClassCRC => 0xDA9B18F2;
	}
}

