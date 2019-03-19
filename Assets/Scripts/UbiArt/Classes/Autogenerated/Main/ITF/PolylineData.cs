using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PolylineData : CSerializable {
		[Serialize("points"        )] public CArray<Vector2> points;
		[Serialize("gameMaterial"  )] public Path gameMaterial;
		[Serialize("regionType"    )] public StringID regionType;
		[Serialize("loop"          )] public bool loop;
		[Serialize("movingPolyline")] public bool movingPolyline;
		[Serialize("Vector2__0"    )] public Vector2 Vector2__0;
		[Serialize("Path__1"       )] public Path Path__1;
		[Serialize("StringID__2"   )] public StringID StringID__2;
		[Serialize("bool__3"       )] public bool bool__3;
		[Serialize("bool__4"       )] public bool bool__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Vector2__0));
				SerializeField(s, nameof(Path__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(bool__4));
			} else {
				SerializeField(s, nameof(points));
				SerializeField(s, nameof(points));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(regionType));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(movingPolyline));
			}
		}
	}
}

