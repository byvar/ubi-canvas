using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatRewriter : CSerializable {
		[Serialize("DefaultAccept")] public bool DefaultAccept;
		[Serialize("Rejected"     )] public CList<StringID> Rejected;
		[Serialize("Rules"        )] public CMap<StringID, StatRewriteRule> Rules;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DefaultAccept));
			SerializeField(s, nameof(Rejected));
			SerializeField(s, nameof(Rules));
		}
	}
}

