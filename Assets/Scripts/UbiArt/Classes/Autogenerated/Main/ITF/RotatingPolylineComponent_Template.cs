using UnityEngine;

namespace UbiArt.ITF {
	public partial class RotatingPolylineComponent_Template : PolylineComponent_Template {
		[Serialize("rotatingPolys")] public CList<RotatingPolylineComponent_Template.RotatingPoly> rotatingPolys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rotatingPolys));
		}
		public partial class RotatingPoly : CSerializable {
			[Serialize("brake"          )] public float brake;
			[Serialize("forceMultiplier")] public float forceMultiplier;
			[Serialize("bone"           )] public StringID bone;
			[Serialize("polylines"      )] public CList<StringID> polylines;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(brake));
				SerializeField(s, nameof(forceMultiplier));
				SerializeField(s, nameof(bone));
				SerializeField(s, nameof(polylines));
			}
		}
		public override uint? ClassCRC => 0x94C84C69;
	}
}

