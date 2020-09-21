using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class FlexMeshBranchComponent : BezierBranchComponent {
		public CListO<FlexMeshBranchComponent.FlexMesh> meshes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				meshes = s.SerializeObject<CListO<FlexMeshBranchComponent.FlexMesh>>(meshes, name: "meshes");
			}
		}
		[Games(GameFlags.RA)]
		public partial class FlexMesh : CSerializable {
			public StringID flexId;
			public float distance;
			public float offset;
			public float length;
			public float width;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				flexId = s.SerializeObject<StringID>(flexId, name: "flexId");
				distance = s.Serialize<float>(distance, name: "distance");
				offset = s.Serialize<float>(offset, name: "offset");
				length = s.Serialize<float>(length, name: "length");
				width = s.Serialize<float>(width, name: "width");
			}
		}
		public override uint? ClassCRC => 0x47EEBCEF;
	}
}

