using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_FoodComponent : ActorComponent {
		[Serialize("powerupLifetime")] public float powerupLifetime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(powerupLifetime));
		}
		public override uint? ClassCRC => 0x63F1C12E;
	}
}

