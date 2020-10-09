using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RuleStatWriter : StatWriter {
		public CMultiMap<StringID, RuleStat> Rules;
		public Generic<StatWriter> Writer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Rules = s.SerializeObject<CMultiMap<StringID, RuleStat>>(Rules, name: "Rules");
			Writer = s.SerializeObject<Generic<StatWriter>>(Writer, name: "Writer");
		}
		public override uint? ClassCRC => 0xB9491D4A;
	}
}

