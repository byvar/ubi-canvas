namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class AnimScaleRepositionedObject : CSerializable {
		public AnimScaleRepositionType repositionType;
		public ObjectPath objectPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			repositionType = s.Serialize<AnimScaleRepositionType>(repositionType, name: "repositionType");
			objectPath = s.SerializeObject<ObjectPath>(objectPath, name: "objectPath");
		}
		public enum AnimScaleRepositionType {
			[Serialize("AnimScaleRepositionType_Top"        )] Top = 0,
			[Serialize("AnimScaleRepositionType_TopRight"   )] TopRight = 1,
			[Serialize("AnimScaleRepositionType_Right"      )] Right = 2,
			[Serialize("AnimScaleRepositionType_BottomRight")] BottomRight = 3,
			[Serialize("AnimScaleRepositionType_Bottom"     )] Bottom = 4,
			[Serialize("AnimScaleRepositionType_BottomLeft" )] BottomLeft = 5,
			[Serialize("AnimScaleRepositionType_Left"       )] Left = 6,
			[Serialize("AnimScaleRepositionType_TopLeft"    )] TopLeft = 7,
		}
	}
}

