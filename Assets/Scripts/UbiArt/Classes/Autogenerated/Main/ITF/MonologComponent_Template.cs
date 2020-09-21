using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class MonologComponent_Template : DialogBaseComponent_Template {
		public CListO<MonologComponent_Template.TextData> textDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				textDataList = s.SerializeObject<CListO<MonologComponent_Template.TextData>>(textDataList, name: "textDataList");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class TextData : CSerializable {
			public StringID textName;
			public LocalisationId locId;
			public string debugText;
			public uint mood;
			public float sizeText;
			public Vec2d offset;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				textName = s.SerializeObject<StringID>(textName, name: "textName");
				locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
				debugText = s.Serialize<string>(debugText, name: "debugText");
				mood = s.Serialize<uint>(mood, name: "mood");
				sizeText = s.Serialize<float>(sizeText, name: "sizeText");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
			}
		}
		public override uint? ClassCRC => 0x0F29342C;
	}
}

