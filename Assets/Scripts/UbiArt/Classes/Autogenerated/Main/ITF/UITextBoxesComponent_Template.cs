using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UITextBoxesComponent_Template : CSerializable {
		[Serialize("isDraw2d"         )] public int isDraw2d;
		[Serialize("useBoneAngle"     )] public int useBoneAngle;
		[Serialize("useBoneScale"     )] public int useBoneScale;
		[Serialize("useScreenRatio"   )] public int useScreenRatio;
		[Serialize("disableActiveSync")] public int disableActiveSync;
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

