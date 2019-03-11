using UnityEngine;

namespace UbiArt.ITF {
	public partial class LogStatHandler : StatHandler {
		[Serialize("Parser")] public Generic<IStatParser> Parser;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Parser));
		}
		public override uint? ClassCRC => 0x41BF63EE;
	}
}

