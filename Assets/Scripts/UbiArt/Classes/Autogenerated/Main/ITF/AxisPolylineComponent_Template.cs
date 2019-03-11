using UnityEngine;

namespace UbiArt.ITF {
	public partial class AxisPolylineComponent_Template : PolylineComponent_Template {
		[Serialize("axisPolylines")] public CList<AxisPolylineComponent_Template.AxisPoly> axisPolylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(axisPolylines));
		}
		public partial class AxisPoly : CSerializable {
			[Serialize("stiff"           )] public float stiff;
			[Serialize("damp"            )] public float damp;
			[Serialize("weightToAngle"   )] public float weightToAngle;
			[Serialize("maxAngle"        )] public Angle maxAngle;
			[Serialize("bone"            )] public StringID bone;
			[Serialize("weightMultiplier")] public float weightMultiplier;
			[Serialize("forceMultiplier" )] public float forceMultiplier;
			[Serialize("polylines"       )] public CList<StringID> polylines;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(stiff));
				SerializeField(s, nameof(damp));
				SerializeField(s, nameof(weightToAngle));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(bone));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(forceMultiplier));
				SerializeField(s, nameof(polylines));
			}
		}
		public override uint? ClassCRC => 0x8B20CBD6;
	}
}

