using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TalkingBubbleComponent_Template : CSerializable {
		public StringID textBone;
		public float maxZoom;
		public float maxRatio;
		public float scaleK;
		public float scaleD;
		public float textDepth;
		public uint charsMinSize;
		public uint charsMaxSize;
		public float widthMinSize;
		public float widthMaxSize;
		public float heightMinSize;
		public float heightMaxSize;
		public Path textActor;
		public Color textColor;
		public int resetOnAppear;
		public int autoPlayOnEndDialog;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textBone = s.SerializeObject<StringID>(textBone, name: "textBone");
			maxZoom = s.Serialize<float>(maxZoom, name: "maxZoom");
			maxRatio = s.Serialize<float>(maxRatio, name: "maxRatio");
			scaleK = s.Serialize<float>(scaleK, name: "scaleK");
			scaleD = s.Serialize<float>(scaleD, name: "scaleD");
			textDepth = s.Serialize<float>(textDepth, name: "textDepth");
			charsMinSize = s.Serialize<uint>(charsMinSize, name: "charsMinSize");
			charsMaxSize = s.Serialize<uint>(charsMaxSize, name: "charsMaxSize");
			widthMinSize = s.Serialize<float>(widthMinSize, name: "widthMinSize");
			widthMaxSize = s.Serialize<float>(widthMaxSize, name: "widthMaxSize");
			heightMinSize = s.Serialize<float>(heightMinSize, name: "heightMinSize");
			heightMaxSize = s.Serialize<float>(heightMaxSize, name: "heightMaxSize");
			textActor = s.SerializeObject<Path>(textActor, name: "textActor");
			textColor = s.SerializeObject<Color>(textColor, name: "textColor");
			resetOnAppear = s.Serialize<int>(resetOnAppear, name: "resetOnAppear");
			autoPlayOnEndDialog = s.Serialize<int>(autoPlayOnEndDialog, name: "autoPlayOnEndDialog");
		}
		public override uint? ClassCRC => 0xD4926024;
	}
}

