using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIEventDisplayTutorial : CSerializable {
		[Serialize("sender"    )] public uint sender;
		[Serialize("tutorialID")] public StringID tutorialID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(tutorialID));
		}
		public override uint? ClassCRC => 0xBD621948;
	}
}

