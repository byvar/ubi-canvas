using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnimSet_Template : CSerializable {
		[Serialize("animations"           )] public CList<SubAnim_Template> animations;
		[Serialize("banksChangeId"        )] public CList<BankIdChange> banksChangeId;
		[Serialize("animPackage"          )] public AnimResourcePackage animPackage;
		[Serialize("ignoreTexturesLoading")] public bool ignoreTexturesLoading;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animations));
			SerializeField(s, nameof(banksChangeId));
			SerializeField(s, nameof(animPackage));
			SerializeField(s, nameof(ignoreTexturesLoading));
		}
	}
}

