using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class StaticMeshElement : CSerializable {
		[Serialize("pos"                      )] public Vector3 pos;
		[Serialize("color"                    )] public Color color;
		[Serialize("animated"                 )] public bool animated;
		[Serialize("frisePath"                )] public ObjectPath frisePath;
		[Serialize("staticVertexList"         )] public CList<VertexPNC3T> staticVertexList;
		[Serialize("Vector3__0"               )] public Vector3 Vector3__0;
		[Serialize("Color__1"                 )] public Color Color__1;
		[Serialize("bool__2"                  )] public bool bool__2;
		[Serialize("ObjectPath__3"            )] public ObjectPath ObjectPath__3;
		[Serialize("CArray<unsigned short>__4")] public CArray<ushort> CArray_ushort__4;
		[Serialize("CArray<VertexPNC3T>__5"   )] public CArray<VertexPNC3T> CArray_VertexPNC3T__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Vector3__0));
				SerializeField(s, nameof(Color__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(ObjectPath__3));
				SerializeField(s, nameof(CArray_ushort__4));
				SerializeField(s, nameof(CArray_VertexPNC3T__5));
			} else {
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(animated));
				SerializeField(s, nameof(frisePath));
				SerializeField(s, nameof(staticVertexList));
			}
		}
	}
}

