using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventInstructionDialog : Event {
		public SmartLocId text;
		public uint mood;
		public float sizeText;
		public Vec2d offset;
		public float durationMin;
		public float actorScaleFactor;
		public string textStr;
		public int snapToScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				textStr = s.Serialize<string>(textStr, name: "text");
				mood = s.Serialize<uint>(mood, name: "mood");
				sizeText = s.Serialize<float>(sizeText, name: "sizeText");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				snapToScreen = s.Serialize<int>(snapToScreen, name: "snapToScreen");
				durationMin = s.Serialize<float>(durationMin, name: "durationMin");
				actorScaleFactor = s.Serialize<float>(actorScaleFactor, name: "actorScaleFactor");
			} else {
				text = s.SerializeObject<SmartLocId>(text, name: "text");
				mood = s.Serialize<uint>(mood, name: "mood");
				sizeText = s.Serialize<float>(sizeText, name: "sizeText");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				durationMin = s.Serialize<float>(durationMin, name: "durationMin");
				actorScaleFactor = s.Serialize<float>(actorScaleFactor, name: "actorScaleFactor");
			}
		}
		public override uint? ClassCRC => 0x171F42E2;
	}
}

