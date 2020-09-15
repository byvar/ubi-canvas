using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RandomAnimBankChangeComponent : ActorComponent {
		public bool isAlreadyCompute;
		public uint NbItem;
		public bool ForceRecompute;
		public CList<strRandomPatchName> PatchNamesToRemove;
		public bool bool__0;
		public bool bool__1;
		public bool bool__2;
		public RandomAnimBankChangeComponent.strRandomAnimBankPart RandomAnimBankChangeComponent_strRandomAnimBankPart__3;
		public strRandomPatchName strRandomPatchName__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
				RandomAnimBankChangeComponent_strRandomAnimBankPart__3 = s.SerializeObject<RandomAnimBankChangeComponent.strRandomAnimBankPart>(RandomAnimBankChangeComponent_strRandomAnimBankPart__3, name: "RandomAnimBankChangeComponent_strRandomAnimBankPart__3");
				strRandomPatchName__4 = s.SerializeObject<strRandomPatchName>(strRandomPatchName__4, name: "strRandomPatchName__4");
			} else {
				isAlreadyCompute = s.Serialize<bool>(isAlreadyCompute, name: "isAlreadyCompute");
				NbItem = s.Serialize<uint>(NbItem, name: "NbItem");
				ForceRecompute = s.Serialize<bool>(ForceRecompute, name: "ForceRecompute");
				PatchNamesToRemove = s.SerializeObject<CList<strRandomPatchName>>(PatchNamesToRemove, name: "PatchNamesToRemove");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class strRandomAnimBankPart : CSerializable {
			public StringID SRC;
			public StringID BankChange;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SRC = s.SerializeObject<StringID>(SRC, name: "SRC");
				BankChange = s.SerializeObject<StringID>(BankChange, name: "BankChange");
			}
		}
		public override uint? ClassCRC => 0xCD65A590;
	}
}

