namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_IphoneAdapter_Template : ActorComponent_Template {
		public Vec3d Vector3__0;
		public StringID StringID__1;
		public bool bool__2;
		public bool bool__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vector3__0 = s.SerializeObject<Vec3d>(Vector3__0, name: "Vector3__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
		}
		public override uint? ClassCRC => 0x9B1B76A4;
	}
}

