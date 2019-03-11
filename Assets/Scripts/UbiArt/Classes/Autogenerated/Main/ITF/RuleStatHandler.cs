using UnityEngine;

namespace UbiArt.ITF {
	public partial class RuleStatHandler : StatHandler {
		[Serialize("Rules")] public CMultiMap<StringID, RuleStat> Rules;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Rules));
		}
		public override uint? ClassCRC => 0x3244ACA0;
	}
}

