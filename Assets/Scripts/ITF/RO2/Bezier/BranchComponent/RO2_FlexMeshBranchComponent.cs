using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.RO2.Bezier.BranchComponents {
	public class RO2_FlexMeshBranchComponent : RO2_BezierBranchComponent {
		[Serialize(0, "meshes")] public Container<FlexMesh> meshes;
		public RO2_FlexMeshBranchComponent(Reader reader) : base(reader) {
		}

		public class FlexMesh : BaseObject {
			[Serialize(0, "flexId")] public StringID flexId;
			[Serialize(1, "distance")] public float distance;
			[Serialize(2, "offset")] public float offset;
			[Serialize(3, "length")] public float length;
			[Serialize(4, "width")] public float width;

			public FlexMesh(Reader reader) : base(reader) {
			}
		}
	}
}
