using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GameOptionsManager_Template : CSerializable {
		[Serialize("defaultOptions")] public Placeholder defaultOptions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultOptions));
		}
		public override uint? ClassCRC => 0xA7FD0D97;
	}
}

