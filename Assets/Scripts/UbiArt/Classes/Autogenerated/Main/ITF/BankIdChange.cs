using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BankIdChange : CSerializable {
		public StringID name;
		public CList<IdRedirect> idRedirect;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			idRedirect = s.SerializeObject<CList<IdRedirect>>(idRedirect, name: "idRedirect");
		}
	}
}

