namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class FriezeConnectionResult : CSerializable {
		public Vec2d pos;
		public ObjectPath prevOwner;
		public uint prevColId;
		public ObjectPath nextOwner;
		public uint nextColId;
		public Vec2d Vector2__0;
		public ObjectPath ObjectPath__1;
		public uint uint__2;
		public ObjectPath ObjectPath__3;
		public uint uint__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
					ObjectPath__1 = s.SerializeObject<ObjectPath>(ObjectPath__1, name: "ObjectPath__1");
					uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
					ObjectPath__3 = s.SerializeObject<ObjectPath>(ObjectPath__3, name: "ObjectPath__3");
					uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
				}
			} else {
				pos = s.SerializeObject<Vec2d>(pos, name: "pos");
				prevOwner = s.SerializeObject<ObjectPath>(prevOwner, name: "prevOwner");
				prevColId = s.Serialize<uint>(prevColId, name: "prevColId");
				nextOwner = s.SerializeObject<ObjectPath>(nextOwner, name: "nextOwner");
				nextColId = s.Serialize<uint>(nextColId, name: "nextColId");
			}
		}
	}
}

