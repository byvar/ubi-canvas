using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_OnlineEventDirectionChange : Event {
		[Serialize("speed"         )] public Vector2 speed;
		[Serialize("position"      )] public Vector2 position;
		[Serialize("bounceX"       )] public float bounceX;
		[Serialize("bounceY"       )] public float bounceY;
		[Serialize("reasonType"    )] public uint reasonType;
		[Serialize("reasonID"      )] public uint reasonID;
		[Serialize("playerOnlineID")] public uint playerOnlineID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(position));
			SerializeField(s, nameof(bounceX));
			SerializeField(s, nameof(bounceY));
			SerializeField(s, nameof(reasonType));
			SerializeField(s, nameof(reasonID));
			SerializeField(s, nameof(playerOnlineID));
		}
		public override uint? ClassCRC => 0x684F2577;
	}
}

