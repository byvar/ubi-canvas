using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SnakeNetworkNodeComponent : TrajectoryNodeComponent {
		[Serialize("data")] public RO2_SnakeNetworkNodeComponent.NodeData data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(data));
		}
		public partial class NodeData : CSerializable {
			[Serialize("speedMultiplier"        )] public float speedMultiplier;
			[Serialize("forceApplySpeed"        )] public bool forceApplySpeed;
			[Serialize("acceleration"           )] public float acceleration;
			[Serialize("accelerationMultiplier" )] public float accelerationMultiplier;
			[Serialize("disableSpeedMultiplier" )] public bool disableSpeedMultiplier;
			[Serialize("stopOnNode"             )] public bool stopOnNode;
			[Serialize("detectionDistMultiplier")] public float detectionDistMultiplier;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(speedMultiplier));
				SerializeField(s, nameof(forceApplySpeed));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(acceleration));
				}
				SerializeField(s, nameof(accelerationMultiplier));
				SerializeField(s, nameof(disableSpeedMultiplier));
				SerializeField(s, nameof(stopOnNode));
				SerializeField(s, nameof(detectionDistMultiplier));
			}
		}
		public override uint? ClassCRC => 0x607C52C5;
	}
}

