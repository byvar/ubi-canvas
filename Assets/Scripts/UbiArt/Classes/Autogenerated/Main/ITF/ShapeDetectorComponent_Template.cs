using UnityEngine;

namespace UbiArt.ITF {
	public partial class ShapeDetectorComponent_Template : DetectorComponent_Template {
		[Serialize("shape"               )] public Generic<PhysShape> shape;
		[Serialize("offset"              )] public Vector2 offset;
		[Serialize("attachPolyline"      )] public StringID attachPolyline;
		[Serialize("attachBone"          )] public StringID attachBone;
		[Serialize("proceduralBone"      )] public StringID proceduralBone;
		[Serialize("animPolylineIDList"  )] public CList<ShapeDetectorComponent_Template.sAnimPoly> animPolylineIDList;
		[Serialize("animPolylineID"      )] public StringID animPolylineID;
		[Serialize("animRefPosPointID"   )] public StringID animRefPosPointID;
		[Serialize("animShapePosPointID" )] public StringID animShapePosPointID;
		[Serialize("shapeIsConcave"      )] public bool shapeIsConcave;
		[Serialize("computeAnimShapeOnce")] public bool computeAnimShapeOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(attachPolyline));
				SerializeField(s, nameof(animPolylineID));
				SerializeField(s, nameof(animRefPosPointID));
				SerializeField(s, nameof(animShapePosPointID));
				SerializeField(s, nameof(shapeIsConcave));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(attachPolyline));
				SerializeField(s, nameof(proceduralBone));
				SerializeField(s, nameof(animPolylineID));
				SerializeField(s, nameof(animRefPosPointID));
				SerializeField(s, nameof(animShapePosPointID));
				SerializeField(s, nameof(shapeIsConcave));
			} else {
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(attachPolyline));
				SerializeField(s, nameof(attachBone));
				SerializeField(s, nameof(proceduralBone));
				SerializeField(s, nameof(animPolylineIDList));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(animPolylineID));
				}
				SerializeField(s, nameof(animRefPosPointID));
				SerializeField(s, nameof(animShapePosPointID));
				SerializeField(s, nameof(shapeIsConcave));
				SerializeField(s, nameof(computeAnimShapeOnce));
			}
		}
		public partial class sAnimPoly : CSerializable {
			[Serialize("AnimPolyName"  )] public StringID AnimPolyName;
			[Serialize("AnimPolyFilter")] public uint AnimPolyFilter;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(AnimPolyName));
				SerializeField(s, nameof(AnimPolyFilter));
			}
		}
		public override uint? ClassCRC => 0xF1C5B894;
	}
}

