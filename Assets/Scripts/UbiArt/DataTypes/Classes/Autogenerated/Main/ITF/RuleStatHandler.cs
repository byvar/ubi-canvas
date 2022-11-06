using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RuleStatHandler : StatHandler {
		public CMultiMap<StringID, RuleStat> Rules;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Rules = s.SerializeObject<CMultiMap<StringID, RuleStat>>(Rules, name: "Rules");
		}
		public override uint? ClassCRC => 0x3244ACA0;
	}
}

