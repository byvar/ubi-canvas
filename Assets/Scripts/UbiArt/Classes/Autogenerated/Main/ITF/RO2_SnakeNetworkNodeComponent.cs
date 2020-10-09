using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SnakeNetworkNodeComponent : TrajectoryNodeComponent {
		public RO2_SnakeNetworkNodeComponent.NodeData data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			data = s.SerializeObject<RO2_SnakeNetworkNodeComponent.NodeData>(data, name: "data");
		}
		[Games(GameFlags.RA)]
		public partial class NodeData : CSerializable {
			public float speedMultiplier;
			public bool forceApplySpeed;
			public float acceleration;
			public float accelerationMultiplier;
			public bool disableSpeedMultiplier;
			public bool stopOnNode;
			public float detectionDistMultiplier;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				speedMultiplier = s.Serialize<float>(speedMultiplier, name: "speedMultiplier");
				forceApplySpeed = s.Serialize<bool>(forceApplySpeed, name: "forceApplySpeed");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					acceleration = s.Serialize<float>(acceleration, name: "acceleration");
				}
				accelerationMultiplier = s.Serialize<float>(accelerationMultiplier, name: "accelerationMultiplier");
				disableSpeedMultiplier = s.Serialize<bool>(disableSpeedMultiplier, name: "disableSpeedMultiplier");
				stopOnNode = s.Serialize<bool>(stopOnNode, name: "stopOnNode");
				detectionDistMultiplier = s.Serialize<float>(detectionDistMultiplier, name: "detectionDistMultiplier");
			}
		}
		public override uint? ClassCRC => 0x607C52C5;
	}
}

