using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCLevelPageContent : CSerializable {
		[Serialize("baseLevel")] public string baseLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(baseLevel));
		}
		public override uint? ClassCRC => 0x72B55C7B;
	}
}

