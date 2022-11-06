using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BlackSwarmSpawnerComponent_Template : CSerializable {
		public float activationDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activationDistance = s.Serialize<float>(activationDistance, name: "activationDistance");
		}
		public override uint? ClassCRC => 0xBE5341F6;
	}
}

