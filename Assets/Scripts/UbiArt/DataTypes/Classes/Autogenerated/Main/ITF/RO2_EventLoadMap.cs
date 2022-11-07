namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventLoadMap : Event {
		public PathRef map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				map = (PathRef)s.SerializeObject<Path>((Path)map, name: "map");
			} else {
				map = s.SerializeObject<PathRef>(map, name: "map");
			}
		}
		public override uint? ClassCRC => 0xA4A0B6EB;
	}
}

