using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UITextBoxesComponent_Template : ActorComponent_Template {
		[Serialize("isDraw2d"         )] public int isDraw2d;
		[Serialize("useBoneAngle"     )] public int useBoneAngle;
		[Serialize("useBoneScale"     )] public int useBoneScale;
		[Serialize("useScreenRatio"   )] public int useScreenRatio;
		[Serialize("disableActiveSync")] public int disableActiveSync;
		[Serialize("textFields"       )] public CArray<UITextField> textFields;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isDraw2d));
			SerializeField(s, nameof(useBoneAngle));
			SerializeField(s, nameof(useBoneScale));
			SerializeField(s, nameof(useScreenRatio));
			SerializeField(s, nameof(disableActiveSync));
			SerializeField(s, nameof(textFields));
		}
		public override uint? ClassCRC => 0x21B539FB;

		[Games(GameFlags.RO)]
		public partial class UITextField : CSerializable {
			[Serialize("textActorPath")] public Path textActorPath;
			[Serialize("fontHeight"   )] public float fontHeight;
			[Serialize("color"        )] public Color color;
			[Serialize("boneName"     )] public StringID boneName;
			[Serialize("lineId"       )] public LocalisationId lineId;
			[Serialize("depthRank"    )] public int depthRank;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(textActorPath));
				SerializeField(s, nameof(fontHeight));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(boneName));
				SerializeField(s, nameof(lineId));
				SerializeField(s, nameof(depthRank));
			}
		}
	}
}

