namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.RAVersion)]
	public partial class SoundComponent : ActorComponent {
		public CListO<SoundDescriptor_Template> soundList;

		public StringID Name;
		public bool UseTriggeringZone;
		public Enum_triggeringZoneType TriggeringZoneType;
		public AABB outerBox = new AABB() { MIN = new Vec2d(-1, -1), MAX = Vec2d.One };

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
			} else if(s.Settings.game == Settings.Game.COL) {
				Name = s.SerializeObject<StringID>(Name, name: "Name");
				soundList = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundList, name: "soundList");
				UseTriggeringZone = s.Serialize<bool>(UseTriggeringZone, name: "UseTriggeringZone", options: CSerializerObject.Options.BoolAsByte);
				TriggeringZoneType = s.Serialize<Enum_triggeringZoneType>(TriggeringZoneType, name: "TriggeringZoneType");
				outerBox = s.SerializeObject<AABB>(outerBox, name: "outerBox");
			} else {
				soundList = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundList, name: "soundList");
			}
		}
		public override uint? ClassCRC => 0x7DD8643C;

		public enum Enum_triggeringZoneType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
	}
}

