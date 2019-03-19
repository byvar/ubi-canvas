using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BankIdChange : CSerializable {
		[Serialize("name"      )] public StringID name;
		[Serialize("idRedirect")] public CList<IdRedirect> idRedirect;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(idRedirect));
		}
	}
}

