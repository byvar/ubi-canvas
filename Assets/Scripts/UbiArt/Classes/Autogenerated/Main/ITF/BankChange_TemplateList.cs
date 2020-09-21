using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BankChange_TemplateList : CSerializable {
		public CListO<TextureBankPath> redirectList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			redirectList = s.SerializeObject<CListO<TextureBankPath>>(redirectList, name: "redirectList");
		}
	}
}

