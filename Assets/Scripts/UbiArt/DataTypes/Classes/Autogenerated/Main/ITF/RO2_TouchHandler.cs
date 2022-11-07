namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_TouchHandler : CSerializable {
		public Generic<PhysShape> shape;
		public bool endDragOnExitShape;
		public bool startDragOnSwipe;
		public bool clampToScreen;
		public uint clampRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
			endDragOnExitShape = s.Serialize<bool>(endDragOnExitShape, name: "endDragOnExitShape");
			startDragOnSwipe = s.Serialize<bool>(startDragOnSwipe, name: "startDragOnSwipe");
			clampToScreen = s.Serialize<bool>(clampToScreen, name: "clampToScreen");
			clampRadius = s.Serialize<uint>(clampRadius, name: "clampRadius");
		}
	}
}

