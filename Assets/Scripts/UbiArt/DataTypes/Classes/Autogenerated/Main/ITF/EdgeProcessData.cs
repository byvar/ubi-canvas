namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class EdgeProcessData : CSerializable {
		public int Id = -1;
		public int IndexStart;
		public int IndexEnd;
		public Vec2d PosStart;
		public Vec2d PosEnd;
		public Vec2d PosOffset;
		public int Count;
		public Vec2d Normal;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Id = s.Serialize<int>(Id, name: "Id");
			IndexStart = s.Serialize<int>(IndexStart, name: "IndexStart");
			IndexEnd = s.Serialize<int>(IndexEnd, name: "IndexEnd");
			PosStart = s.SerializeObject<Vec2d>(PosStart, name: "PosStart");
			PosEnd = s.SerializeObject<Vec2d>(PosEnd, name: "PosEnd");
			PosOffset = s.SerializeObject<Vec2d>(PosOffset, name: "PosOffset");
			Count = s.Serialize<int>(Count, name: "Count");
			Normal = s.SerializeObject<Vec2d>(Normal, name: "Normal");
		}
	}
}

