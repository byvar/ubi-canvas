using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class SubAnimSet_Template : CSerializable {
		public CList<SubAnim_Template> animations;
		public CList<BankIdChange> banksChangeId;
		public AnimResourcePackage animPackage;
		public bool ignoreTexturesLoading;
		public CList<BankChange_Template> banks;
		public CList<string> skipFiles;
		public int redirectDone;
		public CList<Path> resourceList;
		public CList<uint> resourceTypeList;
		public AABB animAABB;
		public CList<uint> nameId;
		public CList<int> nameResIdx;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				animations = s.SerializeObject<CList<SubAnim_Template>>(animations, name: "animations");
				banks = s.SerializeObject<CList<BankChange_Template>>(banks, name: "banks");
				skipFiles = s.SerializeObject<CList<string>>(skipFiles, name: "skipFiles");
				redirectDone = s.Serialize<int>(redirectDone, name: "redirectDone");
				resourceList = s.SerializeObject<CList<Path>>(resourceList, name: "resourceList");
				resourceTypeList = s.SerializeObject<CList<uint>>(resourceTypeList, name: "resourceTypeList");
				animAABB = s.SerializeObject<AABB>(animAABB, name: "animAABB");
				nameId = s.SerializeObject<CList<uint>>(nameId, name: "nameId");
				nameResIdx = s.SerializeObject<CList<int>>(nameResIdx, name: "nameResIdx");
			} else {
				animations = s.SerializeObject<CList<SubAnim_Template>>(animations, name: "animations");
				banksChangeId = s.SerializeObject<CList<BankIdChange>>(banksChangeId, name: "banksChangeId");
				animPackage = s.SerializeObject<AnimResourcePackage>(animPackage, name: "animPackage");
				ignoreTexturesLoading = s.Serialize<bool>(ignoreTexturesLoading, name: "ignoreTexturesLoading");
			}
		}
	}
}

