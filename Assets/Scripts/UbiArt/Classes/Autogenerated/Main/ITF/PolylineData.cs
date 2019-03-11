using UnityEngine;

namespace UbiArt.ITF {
	public partial class PolylineData : CSerializable {
		[Serialize("points"        )] public CArray<Vector2> points;
		[Serialize("gameMaterial"  )] public Path gameMaterial;
		[Serialize("regionType"    )] public StringID regionType;
		[Serialize("loop"          )] public bool loop;
		[Serialize("movingPolyline")] public bool movingPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(points));
			SerializeField(s, nameof(gameMaterial));
			SerializeField(s, nameof(regionType));
			SerializeField(s, nameof(loop));
			SerializeField(s, nameof(movingPolyline));
		}
	}
}

