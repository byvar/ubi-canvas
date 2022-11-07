namespace UbiArt.online {
	public partial class DeviceUIDInfo : CSerializable {
		public string uid;
		public string mdl;
		public string lastuse;
		public string token;
		public string federated_id;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uid = s.Serialize<string>(uid, name: "uid");
			mdl = s.Serialize<string>(mdl, name: "mdl");
			lastuse = s.Serialize<string>(lastuse, name: "lastuse");
			token = s.Serialize<string>(token, name: "token");
			federated_id = s.Serialize<string>(federated_id, name: "federated_id");
		}
	}
}

