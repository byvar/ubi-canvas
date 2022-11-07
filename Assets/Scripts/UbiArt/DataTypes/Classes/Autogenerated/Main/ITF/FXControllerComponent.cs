namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class FXControllerComponent : ActorComponent {
		public bool allowBusMixEvents;
		public bool allowMusicEvents;
		public CMap<StringID, StringID> FXCurrentSwitchRules;
		public int triggerFXisActive;
		public StringID triggerFx;
		public StringID defaultFx;
		public CListO<StringID> defaultFxList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerFXisActive = s.Serialize<int>(triggerFXisActive, name: "triggerFXisActive");
				}
			} else if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					triggerFx = s.SerializeObject<StringID>(triggerFx, name: "triggerFx");
					defaultFx = s.SerializeObject<StringID>(defaultFx, name: "defaultFx");
					allowBusMixEvents = s.Serialize<bool>(allowBusMixEvents, name: "allowBusMixEvents", options: CSerializerObject.Options.BoolAsByte);
					allowMusicEvents = s.Serialize<bool>(allowMusicEvents, name: "allowMusicEvents", options: CSerializerObject.Options.BoolAsByte);
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					triggerFx = s.SerializeObject<StringID>(triggerFx, name: "triggerFx");
					defaultFx = s.SerializeObject<StringID>(defaultFx, name: "defaultFx");
					defaultFxList = s.SerializeObject<CListO<StringID>>(defaultFxList, name: "defaultFxList");
					allowBusMixEvents = s.Serialize<bool>(allowBusMixEvents, name: "allowBusMixEvents", options: CSerializerObject.Options.BoolAsByte);
					allowMusicEvents = s.Serialize<bool>(allowMusicEvents, name: "allowMusicEvents", options: CSerializerObject.Options.BoolAsByte);
				}
			} else if (s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					allowBusMixEvents = s.Serialize<bool>(allowBusMixEvents, name: "allowBusMixEvents");
					allowMusicEvents = s.Serialize<bool>(allowMusicEvents, name: "allowMusicEvents");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					allowBusMixEvents = s.Serialize<bool>(allowBusMixEvents, name: "allowBusMixEvents");
					allowMusicEvents = s.Serialize<bool>(allowMusicEvents, name: "allowMusicEvents");
				}
				if (s.HasFlags(SerializeFlags.Editor)) {
					FXCurrentSwitchRules = s.SerializeObject<CMap<StringID, StringID>>(FXCurrentSwitchRules, name: "FXCurrentSwitchRules");
				}
			}
		}
		public override uint? ClassCRC => 0x8D4FFFB6;
	}
}

