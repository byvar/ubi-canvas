using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BankChange_TemplateList : CSerializable {
		public CList<TextureBankPath> redirectList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			redirectList = s.SerializeObject<CList<TextureBankPath>>(redirectList, name: "redirectList");
		}
	}
}

