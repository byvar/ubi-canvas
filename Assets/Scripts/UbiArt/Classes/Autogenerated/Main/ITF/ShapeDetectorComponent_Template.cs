using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class ShapeDetectorComponent_Template : DetectorComponent_Template {
		[Serialize("shape"                )] public Generic<PhysShape> shape;
		[Serialize("offset"               )] public Vector2 offset;
		[Serialize("attachPolyline"       )] public StringID attachPolyline;
		[Serialize("attachBone"           )] public StringID attachBone;
		[Serialize("proceduralBone"       )] public StringID proceduralBone;
		[Serialize("animPolylineIDList"   )] public CList<ShapeDetectorComponent_Template.sAnimPoly> animPolylineIDList;
		[Serialize("animPolylineID"       )] public StringID animPolylineID;
		[Serialize("animRefPosPointID"    )] public StringID animRefPosPointID;
		[Serialize("animShapePosPointID"  )] public StringID animShapePosPointID;
		[Serialize("shapeIsConcave"       )] public bool shapeIsConcave;
		[Serialize("computeAnimShapeOnce" )] public bool computeAnimShapeOnce;
		[Serialize("shapeIsConcave"       )] public int shapeIsConcave;
		[Serialize("resetOnCheckpoint"    )] public int resetOnCheckpoint;
		[Serialize("useFriezeShape"       )] public bool useFriezeShape;
		[Serialize("Generic<PhysShape>__0")] public Generic<PhysShape> Generic_PhysShape__0;
		[Serialize("Vector2__1"           )] public Vector2 Vector2__1;
		[Serialize("StringID__2"          )] public StringID StringID__2;
		[Serialize("StringID__3"          )] public StringID StringID__3;
		[Serialize("StringID__4"          )] public StringID StringID__4;
		[Serialize("StringID__5"          )] public StringID StringID__5;
		[Serialize("StringID__6"          )] public StringID StringID__6;
		[Serialize("StringID__7"          )] public StringID StringID__7;
		[Serialize("bool__8"              )] public bool bool__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
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
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(resetOnCheckpoint));
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(attachPolyline));
				SerializeField(s, nameof(proceduralBone));
				SerializeField(s, nameof(animPolylineID));
				SerializeField(s, nameof(animRefPosPointID));
				SerializeField(s, nameof(animShapePosPointID));
				SerializeField(s, nameof(shapeIsConcave));
				SerializeField(s, nameof(useFriezeShape), boolAsByte: true);
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Generic_PhysShape__0));
				SerializeField(s, nameof(Vector2__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(StringID__3));
				SerializeField(s, nameof(StringID__4));
				SerializeField(s, nameof(StringID__5));
				SerializeField(s, nameof(StringID__6));
				SerializeField(s, nameof(StringID__7));
				SerializeField(s, nameof(bool__8));
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
		[Games(GameFlags.RA)]
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

