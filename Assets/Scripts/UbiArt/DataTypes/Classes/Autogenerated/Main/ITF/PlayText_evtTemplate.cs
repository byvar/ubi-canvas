namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class PlayText_evtTemplate : SequenceEventWithActor_Template {
		public string Text;
		public float wordTime;
		public uint mood;
		public Vec2d textOffset;
		public LocalisationId localisationId;
		public float sizeText;
		public Path Text2;
		public SimpleTextComponent Params;
		public int textSnapToScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				Text2 = s.SerializeObject<Path>(Text2, name: "Text");
				Params = s.SerializeObject<SimpleTextComponent>(Params, name: "Params");
			} else if (s.Settings.game == Settings.Game.COL) {
				Text = s.Serialize<string>(Text, name: "Text");
				wordTime = s.Serialize<float>(wordTime, name: "wordTime");
				mood = s.Serialize<uint>(mood, name: "mood");
				textOffset = s.SerializeObject<Vec2d>(textOffset, name: "textOffset");
				textSnapToScreen = s.Serialize<int>(textSnapToScreen, name: "textSnapToScreen");
				localisationId = s.SerializeObject<LocalisationId>(localisationId, name: "localisationId");
				sizeText = s.Serialize<float>(sizeText, name: "sizeText");
			} else {
				Text = s.Serialize<string>(Text, name: "Text");
				wordTime = s.Serialize<float>(wordTime, name: "wordTime");
				mood = s.Serialize<uint>(mood, name: "mood");
				textOffset = s.SerializeObject<Vec2d>(textOffset, name: "textOffset");
				localisationId = s.SerializeObject<LocalisationId>(localisationId, name: "localisationId");
				sizeText = s.Serialize<float>(sizeText, name: "sizeText");
			}
		}
		public override uint? ClassCRC => 0x77998139;
	}
}

