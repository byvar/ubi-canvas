using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_OnlineEventDirectionChange : Event {
		public Vec2d speed;
		public Vec2d position;
		public float bounceX;
		public float bounceY;
		public uint reasonType;
		public uint reasonID;
		public uint playerOnlineID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.SerializeObject<Vec2d>(speed, name: "speed");
			position = s.SerializeObject<Vec2d>(position, name: "position");
			bounceX = s.Serialize<float>(bounceX, name: "bounceX");
			bounceY = s.Serialize<float>(bounceY, name: "bounceY");
			reasonType = s.Serialize<uint>(reasonType, name: "reasonType");
			reasonID = s.Serialize<uint>(reasonID, name: "reasonID");
			playerOnlineID = s.Serialize<uint>(playerOnlineID, name: "playerOnlineID");
		}
		public override uint? ClassCRC => 0x684F2577;
	}
}

