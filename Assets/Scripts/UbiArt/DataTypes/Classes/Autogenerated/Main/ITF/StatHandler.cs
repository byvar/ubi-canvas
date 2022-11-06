using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class StatHandler : CSerializable {
		public StatRewriter Rewriter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Rewriter = s.SerializeObject<StatRewriter>(Rewriter, name: "Rewriter");
		}
		public override uint? ClassCRC => 0xF39092A5;
	}
}

