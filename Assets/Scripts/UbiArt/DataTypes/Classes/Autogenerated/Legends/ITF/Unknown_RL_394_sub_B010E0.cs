using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_394_sub_B010E0 : CSerializable {
		public int drcTapEnabled;
		public int drcSwipeEnabled;
		public int drcHoldEnabled;
		public float dragOffsetUp;
		public float dragForceWeight_Left;
		public float dragForceWeight_Right;
		public float dragForceWeight_Up;
		public float dragForceWeight_Down;
		public float dragForceDistance;
		public float speed;
		public float dragForceFadeWeight;
		public Angle turningAngleMax;
		public float normMinToMove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			drcTapEnabled = s.Serialize<int>(drcTapEnabled, name: "drcTapEnabled");
			drcSwipeEnabled = s.Serialize<int>(drcSwipeEnabled, name: "drcSwipeEnabled");
			drcHoldEnabled = s.Serialize<int>(drcHoldEnabled, name: "drcHoldEnabled");
			dragOffsetUp = s.Serialize<float>(dragOffsetUp, name: "dragOffsetUp");
			dragForceWeight_Left = s.Serialize<float>(dragForceWeight_Left, name: "dragForceWeight_Left");
			dragForceWeight_Right = s.Serialize<float>(dragForceWeight_Right, name: "dragForceWeight_Right");
			dragForceWeight_Up = s.Serialize<float>(dragForceWeight_Up, name: "dragForceWeight_Up");
			dragForceWeight_Down = s.Serialize<float>(dragForceWeight_Down, name: "dragForceWeight_Down");
			dragForceDistance = s.Serialize<float>(dragForceDistance, name: "dragForceDistance");
			speed = s.Serialize<float>(speed, name: "speed");
			dragForceFadeWeight = s.Serialize<float>(dragForceFadeWeight, name: "dragForceFadeWeight");
			turningAngleMax = s.SerializeObject<Angle>(turningAngleMax, name: "turningAngleMax");
			normMinToMove = s.Serialize<float>(normMinToMove, name: "normMinToMove");
		}
		public override uint? ClassCRC => 0x2AC12BCC;
	}
}

