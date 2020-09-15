using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeNetworkComponent : ActorComponent {
		[Serialize("nodes")] public CList<RO2_SnakeNetworkComponent.Node> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
		}
		[Games(GameFlags.RA)]
		public partial class Node : CSerializable {
			[Serialize("id"      )] public uint id;
			[Serialize("pos"     )] public Vec3d pos;
			[Serialize("childIds")] public CArray<uint> childIds;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(childIds));
				SerializeField(s, nameof(childIds));
			}
		}
		public override uint? ClassCRC => 0x2A1BBAD4;
	}
}

