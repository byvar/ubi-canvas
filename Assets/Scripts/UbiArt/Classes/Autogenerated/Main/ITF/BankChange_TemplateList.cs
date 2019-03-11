using UnityEngine;

namespace UbiArt.ITF {
	public partial class BankChange_TemplateList : CSerializable {
		[Serialize("redirectList")] public CList<TextureBankPath> redirectList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(redirectList));
		}
	}
}

