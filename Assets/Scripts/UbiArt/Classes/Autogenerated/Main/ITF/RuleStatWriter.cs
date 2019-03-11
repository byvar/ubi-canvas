using UnityEngine;

namespace UbiArt.ITF {
	public partial class RuleStatWriter : StatWriter {
		[Serialize("Rules" )] public CMultiMap<StringID, RuleStat> Rules;
		[Serialize("Writer")] public Generic<StatWriter> Writer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Rules));
			SerializeField(s, nameof(Writer));
		}
		public override uint? ClassCRC => 0xB9491D4A;
	}
}

