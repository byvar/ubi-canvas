using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BlackSwarmSpawnerComponent_Template : CSerializable {
		[Serialize("activationDistance")] public float activationDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activationDistance));
		}
		public override uint? ClassCRC => 0xBE5341F6;
	}
}

