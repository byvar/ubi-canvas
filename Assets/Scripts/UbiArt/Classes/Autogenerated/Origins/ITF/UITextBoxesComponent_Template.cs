using UnityEngine;

namespace UbiArt.ITF {
	public partial class UITextBoxesComponent_Template : CSerializable {
		[Serialize("isDraw2d"         )] public bool isDraw2d;
		[Serialize("useBoneAngle"     )] public bool useBoneAngle;
		[Serialize("useBoneScale"     )] public bool useBoneScale;
		[Serialize("useScreenRatio"   )] public bool useScreenRatio;
		[Serialize("disableActiveSync")] public bool disableActiveSync;
		[Serialize("textFields"       )] public Placeholder textFields;
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
	}
}

