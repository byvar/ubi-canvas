using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class UnlockedGadgets : CSerializable {
		public uint uint__0;
		public Gadgets Gadgets__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			Gadgets__1 = s.SerializeObject<Gadgets>(Gadgets__1, name: "Gadgets__1");
		}
	}
}

