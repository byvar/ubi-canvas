using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class FlexMeshBranchComponent : BezierBranchComponent {
		[Serialize("meshes")] public CList<FlexMeshBranchComponent.FlexMesh> meshes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(meshes));
			}
		}
		[Games(GameFlags.RA)]
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

