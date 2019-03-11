using UnityEngine;

namespace UbiArt.ITF {
	public partial class StatHandler : CSerializable {
		[Serialize("Rewriter")] public StatRewriter Rewriter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Rewriter));
		}
		public override uint? ClassCRC => 0xF39092A5;
	}
}

