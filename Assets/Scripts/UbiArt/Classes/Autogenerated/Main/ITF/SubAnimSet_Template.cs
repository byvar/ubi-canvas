using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class SubAnimSet_Template : CSerializable {
		[Serialize("animations"                   )] public CList<SubAnim_Template> animations;
		[Serialize("banksChangeId"                )] public CList<BankIdChange> banksChangeId;
		[Serialize("animPackage"                  )] public AnimResourcePackage animPackage;
		[Serialize("ignoreTexturesLoading"        )] public bool ignoreTexturesLoading;
		[Serialize("CList<SubAnim_Template>__0"   )] public CList<SubAnim_Template> CList_SubAnim_Template__0;
		[Serialize("CList<BankChange_Template>__1")] public CList<BankChange_Template> CList_BankChange_Template__1;
		[Serialize("CList<string>__2"             )] public CList<string> CList_string__2;
		[Serialize("int__3"                       )] public int int__3;
		[Serialize("CList<Path>__4"               )] public CList<Path> CList_Path__4;
		[Serialize("CList<uint>__5"               )] public CList<uint> CList_uint__5;
		[Serialize("AABB__6"                      )] public AABB AABB__6;
		[Serialize("CList<uint>__7"               )] public CList<uint> CList_uint__7;
		[Serialize("CList<int>__8"                )] public CList<int> CList_int__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(CList_SubAnim_Template__0));
				SerializeField(s, nameof(CList_BankChange_Template__1));
				SerializeField(s, nameof(CList_string__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(CList_Path__4));
				SerializeField(s, nameof(CList_uint__5));
				SerializeField(s, nameof(AABB__6));
				SerializeField(s, nameof(CList_uint__7));
				SerializeField(s, nameof(CList_int__8));
			} else {
				SerializeField(s, nameof(animations));
				SerializeField(s, nameof(banksChangeId));
				SerializeField(s, nameof(animPackage));
				SerializeField(s, nameof(ignoreTexturesLoading));
			}
		}
	}
}

