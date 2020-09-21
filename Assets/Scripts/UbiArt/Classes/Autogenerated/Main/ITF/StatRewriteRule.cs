using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatRewriteRule : CSerializable {
		public bool DefaultAccept;
		public CListO<StringID> Rejected;
		public CMap<StringID, string> Rules;
		public string RewroteName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DefaultAccept = s.Serialize<bool>(DefaultAccept, name: "DefaultAccept");
			Rejected = s.SerializeObject<CListO<StringID>>(Rejected, name: "Rejected");
			Rules = s.SerializeObject<CMap<StringID, string>>(Rules, name: "Rules");
			RewroteName = s.Serialize<string>(RewroteName, name: "RewroteName");
		}
	}
}

