using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_472_sub_B946E0 : CSerializable {
		[Serialize("distanceFromSide")] public float distanceFromSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(distanceFromSide));
		}
		public override uint? ClassCRC => 0xB98E4D8D;
	}
}

