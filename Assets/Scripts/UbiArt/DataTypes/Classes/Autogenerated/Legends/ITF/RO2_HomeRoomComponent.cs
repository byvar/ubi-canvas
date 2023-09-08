namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeRoomComponent : RO2_HomeComponent {
		public SmartLocId name;
		public StringID world;
		public SmartLocId locationID;
		public StringID presence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<SmartLocId>(name, name: "name");
			world = s.SerializeObject<StringID>(world, name: "world");
			locationID = s.SerializeObject<SmartLocId>(locationID, name: "locationID");
			if (s.Settings.Platform != GamePlatform.Vita) {
				presence = s.SerializeObject<StringID>(presence, name: "presence");
			}
		}
		public override uint? ClassCRC => 0x8E4C8FC7;
	}
}

