using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SnakeRideBodyPart_Template : RO2_SnakeBodyPartAmv_Template {
		[Serialize("animTickle")] public StringID animTickle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animTickle));
		}
		public override uint? ClassCRC => 0xA02799E6;
	}
}

