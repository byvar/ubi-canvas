using UnityEngine;

namespace UbiArt.ITF {
	public partial class ShapeComponent_Template : ActorComponent_Template {
		[Serialize("AnimPolylineList")] public CList<StringID> AnimPolylineList;
		[Serialize("shape"           )] public Generic<PhysShape> shape;
		[Serialize("offset"          )] public Vector2 offset;
		[Serialize("attachPolyline"  )] public StringID attachPolyline;
		[Serialize("proceduralBone"  )] public StringID proceduralBone;
		[Serialize("shapes"          )] public CList<ShapeData_Template> shapes;
		[Serialize("useAABBShape"    )] public bool useAABBShape;
		[Serialize("bone"            )] public StringID bone;
		[Serialize("bone3D"          )] public StringID bone3D;
		[Serialize("polyline"        )] public StringID polyline;
		[Serialize("drawDebug"       )] public bool drawDebug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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

