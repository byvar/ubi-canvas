using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class ZRollOff : SoundModifier {
		[Serialize("distanceMin")] public float distanceMin;
		[Serialize("distanceMax")] public float distanceMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(distanceMin));
			SerializeField(s, nameof(distanceMax));
		}
		public override uint? ClassCRC => 0xDA9B18F2;
	}
}

