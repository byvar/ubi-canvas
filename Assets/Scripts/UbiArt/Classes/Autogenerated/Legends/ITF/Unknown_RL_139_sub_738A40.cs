using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_139_sub_738A40 : CSerializable {
		[Serialize("treasureTextFriendly"     )] public StringID treasureTextFriendly;
		[Serialize("participationTextFriendly")] public StringID participationTextFriendly;
		[Serialize("treasureValueSpeed"       )] public float treasureValueSpeed;
		[Serialize("participationValueSpeed"  )] public float participationValueSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(treasureTextFriendly));
			SerializeField(s, nameof(participationTextFriendly));
			SerializeField(s, nameof(treasureValueSpeed));
			SerializeField(s, nameof(participationValueSpeed));
		}
		public override uint? ClassCRC => 0x8C586D1A;
	}
}

