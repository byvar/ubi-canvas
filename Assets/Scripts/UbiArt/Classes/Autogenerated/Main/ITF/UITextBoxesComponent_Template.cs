using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UITextBoxesComponent_Template : ActorComponent_Template {
		public int isDraw2d;
		public int useBoneAngle;
		public int useBoneScale;
		public int useScreenRatio;
		public int disableActiveSync;
		public CArray<UITextField> textFields;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isDraw2d = s.Serialize<int>(isDraw2d, name: "isDraw2d");
			useBoneAngle = s.Serialize<int>(useBoneAngle, name: "useBoneAngle");
			useBoneScale = s.Serialize<int>(useBoneScale, name: "useBoneScale");
			useScreenRatio = s.Serialize<int>(useScreenRatio, name: "useScreenRatio");
			disableActiveSync = s.Serialize<int>(disableActiveSync, name: "disableActiveSync");
			textFields = s.SerializeObject<CArray<UITextField>>(textFields, name: "textFields");
		}
		public override uint? ClassCRC => 0x21B539FB;

		[Games(GameFlags.RO)]
		public partial class UITextField : CSerializable {
			public Path textActorPath;
			public float fontHeight;
			public Color color;
			public StringID boneName;
			public LocalisationId lineId;
			public int depthRank;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				textActorPath = s.SerializeObject<Path>(textActorPath, name: "textActorPath");
				fontHeight = s.Serialize<float>(fontHeight, name: "fontHeight");
				color = s.SerializeObject<Color>(color, name: "color");
				boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
				lineId = s.SerializeObject<LocalisationId>(lineId, name: "lineId");
				depthRank = s.Serialize<int>(depthRank, name: "depthRank");
			}
		}
	}
}

