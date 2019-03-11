using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerSelection_Stick : TriggerSelectionAbstract {
		[Serialize("Self"    )] public bool Self;
		[Serialize("TagName" )] public StringID TagName;
		[Serialize("TagValue")] public uint TagValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Self));
			SerializeField(s, nameof(TagName));
			SerializeField(s, nameof(TagValue));
		}
		public override uint? ClassCRC => 0x3A0A6EFE;
	}
}

