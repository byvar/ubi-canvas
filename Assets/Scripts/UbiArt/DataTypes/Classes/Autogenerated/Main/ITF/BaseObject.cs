namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BaseObject : CSerializable {
		public ObjectId OBJECTID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.EngineVersion == EngineVersion.RO) {
				OBJECTID = s.SerializeObject<ObjectId>(OBJECTID, name: "OBJECTID");
			}
		}
		public override uint? ClassCRC => 0xBFC64EFB;
	}
}

