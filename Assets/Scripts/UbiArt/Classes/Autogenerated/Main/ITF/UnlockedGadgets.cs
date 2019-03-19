using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class UnlockedGadgets : CSerializable {
		[Serialize("uint__0"   )] public uint uint__0;
		[Serialize("Gadgets__1")] public Gadgets Gadgets__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(Gadgets__1));
		}
	}
}

