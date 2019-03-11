using UnityEngine;

namespace UbiArt.ITF {
	public partial class RandomAnimBankChangeComponent : ActorComponent {
		[Serialize("isAlreadyCompute"  )] public bool isAlreadyCompute;
		[Serialize("NbItem"            )] public uint NbItem;
		[Serialize("ForceRecompute"    )] public bool ForceRecompute;
		[Serialize("PatchNamesToRemove")] public CList<strRandomPatchName> PatchNamesToRemove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isAlreadyCompute));
			SerializeField(s, nameof(NbItem));
			SerializeField(s, nameof(ForceRecompute));
			SerializeField(s, nameof(PatchNamesToRemove));
		}
		public partial class strRandomAnimBankPart : CSerializable {
			[Serialize("SRC"       )] public StringID SRC;
			[Serialize("BankChange")] public StringID BankChange;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(SRC));
				SerializeField(s, nameof(BankChange));
			}
		}
		public override uint? ClassCRC => 0xCD65A590;
	}
}

