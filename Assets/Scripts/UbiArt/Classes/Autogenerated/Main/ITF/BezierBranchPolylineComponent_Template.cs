using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchPolylineComponent_Template : BezierBranchComponent_Template {
		[Serialize("gameMaterial"      )] public Path gameMaterial;
		[Serialize("beginLength"       )] public float beginLength;
		[Serialize("endLength"         )] public float endLength;
		[Serialize("beginWidth"        )] public float beginWidth;
		[Serialize("midWidth"          )] public float midWidth;
		[Serialize("endWidth"          )] public float endWidth;
		[Serialize("startOffset"       )] public float startOffset;
		[Serialize("endOffset"         )] public float endOffset;
		[Serialize("tessellationLength")] public float tessellationLength;
		[Serialize("usePolylinePhantom")] public bool usePolylinePhantom;
		[Serialize("isJobable"         )] public bool isJobable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gameMaterial));
			SerializeField(s, nameof(beginLength));
			SerializeField(s, nameof(endLength));
			SerializeField(s, nameof(beginWidth));
			SerializeField(s, nameof(midWidth));
			SerializeField(s, nameof(endWidth));
			SerializeField(s, nameof(startOffset));
			SerializeField(s, nameof(endOffset));
			SerializeField(s, nameof(tessellationLength));
			SerializeField(s, nameof(usePolylinePhantom));
			SerializeField(s, nameof(isJobable));
		}
		public override uint? ClassCRC => 0xA01092F1;
	}
}

