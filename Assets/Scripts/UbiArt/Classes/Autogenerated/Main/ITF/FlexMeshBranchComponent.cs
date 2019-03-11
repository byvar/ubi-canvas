using UnityEngine;

namespace UbiArt.ITF {
	public partial class FlexMeshBranchComponent : BezierBranchComponent {
		[Serialize("meshes")] public CList<FlexMeshBranchComponent.FlexMesh> meshes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(meshes));
		}
		public partial class FlexMesh : CSerializable {
			[Serialize("flexId"  )] public StringID flexId;
			[Serialize("distance")] public float distance;
			[Serialize("offset"  )] public float offset;
			[Serialize("length"  )] public float length;
			[Serialize("width"   )] public float width;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(flexId));
				SerializeField(s, nameof(distance));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(length));
				SerializeField(s, nameof(width));
			}
		}
		public override uint? ClassCRC => 0x47EEBCEF;
	}
}

