using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_FoodComponent : ActorComponent {
		public float powerupLifetime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			powerupLifetime = s.Serialize<float>(powerupLifetime, name: "powerupLifetime");
		}
		public override uint? ClassCRC => 0x63F1C12E;
	}
}

