using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatRewriteRule : CSerializable {
		[Serialize("DefaultAccept")] public bool DefaultAccept;
		[Serialize("Rejected"     )] public CList<StringID> Rejected;
		[Serialize("Rules"        )] public CMap<StringID, string> Rules;
		[Serialize("RewroteName"  )] public string RewroteName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DefaultAccept));
			SerializeField(s, nameof(Rejected));
			SerializeField(s, nameof(Rules));
			SerializeField(s, nameof(RewroteName));
		}
	}
}

