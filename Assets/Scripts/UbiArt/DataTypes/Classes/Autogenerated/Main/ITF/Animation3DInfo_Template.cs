namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Animation3DInfo_Template : CSerializable {
		public StringID friendlyName;
		public Path name;
		public float playRate;
		public bool loop;
		public bool reverse;
		public bool procedural;
		public bool sync;
		public float syncRatio;
		public bool allowSyncOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			friendlyName = s.SerializeObject<StringID>(friendlyName, name: "friendlyName");
			name = s.SerializeObject<Path>(name, name: "name");
			playRate = s.Serialize<float>(playRate, name: "playRate");
			loop = s.Serialize<bool>(loop, name: "loop");
			reverse = s.Serialize<bool>(reverse, name: "reverse");
			procedural = s.Serialize<bool>(procedural, name: "procedural");
			sync = s.Serialize<bool>(sync, name: "sync");
			syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
			allowSyncOffset = s.Serialize<bool>(allowSyncOffset, name: "allowSyncOffset");
		}
	}
}

