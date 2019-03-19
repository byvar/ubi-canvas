using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerSelection_Link : TriggerSelectionAbstract {
		[Serialize("Static"  )] public bool Static;
		[Serialize("TagName" )] public StringID TagName;
		[Serialize("TagValue")] public uint TagValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Static));
			SerializeField(s, nameof(TagName));
			SerializeField(s, nameof(TagValue));
		}
		public override uint? ClassCRC => 0xFF2742F0;
	}
}

