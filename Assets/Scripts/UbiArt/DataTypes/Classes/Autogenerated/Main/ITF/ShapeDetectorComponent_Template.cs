namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ShapeDetectorComponent_Template : DetectorComponent_Template {
		public Generic<PhysShape> shape;
		public Vec2d offset;
		public StringID attachPolyline;
		public StringID attachBone;
		public StringID proceduralBone;
		public CListO<ShapeDetectorComponent_Template.sAnimPoly> animPolylineIDList;
		public StringID animPolylineID;
		public StringID animRefPosPointID;
		public StringID animShapePosPointID;
		public bool shapeIsConcave;
		public bool computeAnimShapeOnce;
		public bool useFriezeShape;
		public StringID StringID__3;
		public StringID StringID__4;
		public StringID StringID__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				attachPolyline = s.SerializeObject<StringID>(attachPolyline, name: "attachPolyline");
				animPolylineID = s.SerializeObject<StringID>(animPolylineID, name: "animPolylineID");
				animRefPosPointID = s.SerializeObject<StringID>(animRefPosPointID, name: "animRefPosPointID");
				animShapePosPointID = s.SerializeObject<StringID>(animShapePosPointID, name: "animShapePosPointID");
				shapeIsConcave = s.Serialize<bool>(shapeIsConcave, name: "shapeIsConcave");
			} else if (s.Settings.game == Settings.Game.RL) {
				shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				attachPolyline = s.SerializeObject<StringID>(attachPolyline, name: "attachPolyline");
				proceduralBone = s.SerializeObject<StringID>(proceduralBone, name: "proceduralBone");
				animPolylineID = s.SerializeObject<StringID>(animPolylineID, name: "animPolylineID");
				animRefPosPointID = s.SerializeObject<StringID>(animRefPosPointID, name: "animRefPosPointID");
				animShapePosPointID = s.SerializeObject<StringID>(animShapePosPointID, name: "animShapePosPointID");
				shapeIsConcave = s.Serialize<bool>(shapeIsConcave, name: "shapeIsConcave");
			} else if (s.Settings.game == Settings.Game.COL) {
				shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				attachPolyline = s.SerializeObject<StringID>(attachPolyline, name: "attachPolyline");
				proceduralBone = s.SerializeObject<StringID>(proceduralBone, name: "proceduralBone");
				animPolylineID = s.SerializeObject<StringID>(animPolylineID, name: "animPolylineID");
				animRefPosPointID = s.SerializeObject<StringID>(animRefPosPointID, name: "animRefPosPointID");
				animShapePosPointID = s.SerializeObject<StringID>(animShapePosPointID, name: "animShapePosPointID");
				shapeIsConcave = s.Serialize<bool>(shapeIsConcave, name: "shapeIsConcave");
				useFriezeShape = s.Serialize<bool>(useFriezeShape, name: "useFriezeShape", options: CSerializerObject.Options.BoolAsByte);
			} else if (s.Settings.game == Settings.Game.VH) {
				shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				attachPolyline = s.SerializeObject<StringID>(attachPolyline, name: "attachPolyline");
				attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
				proceduralBone = s.SerializeObject<StringID>(proceduralBone, name: "proceduralBone");
				animPolylineID = s.SerializeObject<StringID>(animPolylineID, name: "animPolylineID");
				animRefPosPointID = s.SerializeObject<StringID>(animRefPosPointID, name: "animRefPosPointID");
				animShapePosPointID = s.SerializeObject<StringID>(animShapePosPointID, name: "animShapePosPointID");
				shapeIsConcave = s.Serialize<bool>(shapeIsConcave, name: "shapeIsConcave");
			} else {
				shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				attachPolyline = s.SerializeObject<StringID>(attachPolyline, name: "attachPolyline");
				attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
				proceduralBone = s.SerializeObject<StringID>(proceduralBone, name: "proceduralBone");
				animPolylineIDList = s.SerializeObject<CListO<ShapeDetectorComponent_Template.sAnimPoly>>(animPolylineIDList, name: "animPolylineIDList");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					animPolylineID = s.SerializeObject<StringID>(animPolylineID, name: "animPolylineID");
				}
				animRefPosPointID = s.SerializeObject<StringID>(animRefPosPointID, name: "animRefPosPointID");
				animShapePosPointID = s.SerializeObject<StringID>(animShapePosPointID, name: "animShapePosPointID");
				shapeIsConcave = s.Serialize<bool>(shapeIsConcave, name: "shapeIsConcave");
				computeAnimShapeOnce = s.Serialize<bool>(computeAnimShapeOnce, name: "computeAnimShapeOnce");
			}
		}
		[Games(GameFlags.RA)]
		public partial class sAnimPoly : CSerializable {
			public StringID AnimPolyName;
			public uint AnimPolyFilter;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				AnimPolyName = s.SerializeObject<StringID>(AnimPolyName, name: "AnimPolyName");
				AnimPolyFilter = s.Serialize<uint>(AnimPolyFilter, name: "AnimPolyFilter");
			}
		}
		public override uint? ClassCRC => 0xF1C5B894;
	}
}

