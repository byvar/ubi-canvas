namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class CameraSubjectComponent_Template : ActorComponent_Template {
		public Vec2d boundingBoxMin;
		public Vec2d boundingBoxMax;
		public Vec2d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			boundingBoxMin = s.SerializeObject<Vec2d>(boundingBoxMin, name: "boundingBoxMin");
			boundingBoxMax = s.SerializeObject<Vec2d>(boundingBoxMax, name: "boundingBoxMax");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
		}
		public override uint? ClassCRC => 0x5B4423A1;
	}
}

