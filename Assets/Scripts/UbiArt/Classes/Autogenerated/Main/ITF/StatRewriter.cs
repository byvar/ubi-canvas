using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatRewriter : CSerializable {
		public bool DefaultAccept;
		public CList<StringID> Rejected;
		public CMap<StringID, StatRewriteRule> Rules;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DefaultAccept = s.Serialize<bool>(DefaultAccept, name: "DefaultAccept");
			Rejected = s.SerializeObject<CList<StringID>>(Rejected, name: "Rejected");
			Rules = s.SerializeObject<CMap<StringID, StatRewriteRule>>(Rules, name: "Rules");
		}
	}
}

