using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeNetworkComponent : ActorComponent {
		public CList<RO2_SnakeNetworkComponent.Node> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CList<RO2_SnakeNetworkComponent.Node>>(nodes, name: "nodes");
		}
		[Games(GameFlags.RA)]
		public partial class Node : CSerializable {
			public uint id;
			public Vec3d pos;
			public CArray<uint> childIds;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				id = s.Serialize<uint>(id, name: "id");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				childIds = s.SerializeObject<CArray<uint>>(childIds, name: "childIds");
				childIds = s.SerializeObject<CArray<uint>>(childIds, name: "childIds");
			}
		}
		public override uint? ClassCRC => 0x2A1BBAD4;
	}
}

