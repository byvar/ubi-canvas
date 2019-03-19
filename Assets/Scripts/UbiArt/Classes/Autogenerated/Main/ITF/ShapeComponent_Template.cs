using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class ShapeComponent_Template : ActorComponent_Template {
		[Serialize("AnimPolylineList"             )] public CList<StringID> AnimPolylineList;
		[Serialize("shape"                        )] public Generic<PhysShape> shape;
		[Serialize("offset"                       )] public Vector2 offset;
		[Serialize("attachPolyline"               )] public StringID attachPolyline;
		[Serialize("proceduralBone"               )] public StringID proceduralBone;
		[Serialize("shapes"                       )] public CList<ShapeData_Template> shapes;
		[Serialize("useAABBShape"                 )] public bool useAABBShape;
		[Serialize("bone"                         )] public StringID bone;
		[Serialize("bone3D"                       )] public StringID bone3D;
		[Serialize("polyline"                     )] public StringID polyline;
		[Serialize("drawDebug"                    )] public int drawDebug;
		[Serialize("StringID__0"                  )] public StringID StringID__0;
		[Serialize("Generic<PhysShape>__1"        )] public Generic<PhysShape> Generic_PhysShape__1;
		[Serialize("Vector2__2"                   )] public Vector2 Vector2__2;
		[Serialize("StringID__3"                  )] public StringID StringID__3;
		[Serialize("CArray<ShapeData_Template>__4")] public CArray<ShapeData_Template> CArray_ShapeData_Template__4;
		[Serialize("int__5"                       )] public int int__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(Generic_PhysShape__1));
				SerializeField(s, nameof(Vector2__2));
				SerializeField(s, nameof(StringID__3));
				SerializeField(s, nameof(CArray_ShapeData_Template__4));
				SerializeField(s, nameof(int__5));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(polyline));
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(attachPolyline));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(drawDebug));
				}
				SerializeField(s, nameof(shapes));
				SerializeField(s, nameof(useAABBShape));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(polyline));
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(attachPolyline));
				SerializeField(s, nameof(proceduralBone));
				SerializeField(s, nameof(shapes));
				SerializeField(s, nameof(useAABBShape));
				SerializeField(s, nameof(bone));
				SerializeField(s, nameof(bone3D));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(polyline));
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(attachPolyline));
				SerializeField(s, nameof(proceduralBone));
				SerializeField(s, nameof(useAABBShape), boolAsByte: true);
				SerializeField(s, nameof(bone));
				SerializeField(s, nameof(bone3D));
			} else {
				SerializeField(s, nameof(AnimPolylineList));
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(attachPolyline));
				SerializeField(s, nameof(proceduralBone));
				SerializeField(s, nameof(shapes));
				SerializeField(s, nameof(useAABBShape));
				SerializeField(s, nameof(bone));
				SerializeField(s, nameof(bone3D));
			}
		}
		public override uint? ClassCRC => 0x06B15761;
	}
}

