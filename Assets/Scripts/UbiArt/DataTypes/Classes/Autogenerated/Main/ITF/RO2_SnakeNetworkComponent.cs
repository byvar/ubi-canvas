namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SnakeNetworkComponent : ActorComponent {
		public CListO<RO2_SnakeNetworkComponent.Node> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<RO2_SnakeNetworkComponent.Node>>(nodes, name: "nodes");
		}
		[Games(GameFlags.RA)]
		public partial class Node : CSerializable {
			public uint id;
			public Vec3d pos;
			public CArrayP<uint> childIds;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				id = s.Serialize<uint>(id, name: "id");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				childIds = s.SerializeObject<CArrayP<uint>>(childIds, name: "childIds");
			}
		}
		public override uint? ClassCRC => 0x2A1BBAD4;
	}
}

