using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_TalkingBubbleComponent_Template : CSerializable {
		[Serialize("textBone"           )] public StringID textBone;
		[Serialize("maxZoom"            )] public float maxZoom;
		[Serialize("maxRatio"           )] public float maxRatio;
		[Serialize("scaleK"             )] public float scaleK;
		[Serialize("scaleD"             )] public float scaleD;
		[Serialize("textDepth"          )] public float textDepth;
		[Serialize("charsMinSize"       )] public uint charsMinSize;
		[Serialize("charsMaxSize"       )] public uint charsMaxSize;
		[Serialize("widthMinSize"       )] public float widthMinSize;
		[Serialize("widthMaxSize"       )] public float widthMaxSize;
		[Serialize("heightMinSize"      )] public float heightMinSize;
		[Serialize("heightMaxSize"      )] public float heightMaxSize;
		[Serialize("textActor"          )] public Path textActor;
		[Serialize("textColor"          )] public Color textColor;
		[Serialize("resetOnAppear"      )] public bool resetOnAppear;
		[Serialize("autoPlayOnEndDialog")] public bool autoPlayOnEndDialog;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textBone));
			SerializeField(s, nameof(maxZoom));
			SerializeField(s, nameof(maxRatio));
			SerializeField(s, nameof(scaleK));
			SerializeField(s, nameof(scaleD));
			SerializeField(s, nameof(textDepth));
			SerializeField(s, nameof(charsMinSize));
			SerializeField(s, nameof(charsMaxSize));
			SerializeField(s, nameof(widthMinSize));
			SerializeField(s, nameof(widthMaxSize));
			SerializeField(s, nameof(heightMinSize));
			SerializeField(s, nameof(heightMaxSize));
			SerializeField(s, nameof(textActor));
			SerializeField(s, nameof(textColor));
			SerializeField(s, nameof(resetOnAppear));
			SerializeField(s, nameof(autoPlayOnEndDialog));
		}
		public override uint? ClassCRC => 0xD4926024;
	}
}

