using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RandomAnimBankChangeComponent : ActorComponent {
		[Serialize("isAlreadyCompute"                                      )] public bool isAlreadyCompute;
		[Serialize("NbItem"                                                )] public uint NbItem;
		[Serialize("ForceRecompute"                                        )] public bool ForceRecompute;
		[Serialize("PatchNamesToRemove"                                    )] public CList<strRandomPatchName> PatchNamesToRemove;
		[Serialize("bool__0"                                               )] public bool bool__0;
		[Serialize("bool__1"                                               )] public bool bool__1;
		[Serialize("bool__2"                                               )] public bool bool__2;
		[Serialize("RandomAnimBankChangeComponent.strRandomAnimBankPart__3")] public RandomAnimBankChangeComponent.strRandomAnimBankPart RandomAnimBankChangeComponent_strRandomAnimBankPart__3;
		[Serialize("strRandomPatchName__4"                                 )] public strRandomPatchName strRandomPatchName__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(RandomAnimBankChangeComponent_strRandomAnimBankPart__3));
				SerializeField(s, nameof(strRandomPatchName__4));
			} else {
				SerializeField(s, nameof(isAlreadyCompute));
				SerializeField(s, nameof(NbItem));
				SerializeField(s, nameof(ForceRecompute));
				SerializeField(s, nameof(PatchNamesToRemove));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
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

