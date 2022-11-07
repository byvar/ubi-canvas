namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class SubAnimSet_Template : CSerializable {
		public CListO<SubAnim_Template> animations;
		public CListO<BankIdChange> banksChangeId;
		public AnimResourcePackage animPackage;
		public bool ignoreTexturesLoading;
		public CListO<BankChange_Template> banks;
		public CListP<string> skipFiles;
		public int redirectDone;
		public CListO<Path> resourceList;
		public CListP<uint> resourceTypeList;
		public AABB animAABB;
		public CListP<uint> nameId;
		public CListP<int> nameResIdx;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				animations = s.SerializeObject<CListO<SubAnim_Template>>(animations, name: "animations");
				banks = s.SerializeObject<CListO<BankChange_Template>>(banks, name: "banks");
				skipFiles = s.SerializeObject<CListP<string>>(skipFiles, name: "skipFiles");
				redirectDone = s.Serialize<int>(redirectDone, name: "redirectDone");
				resourceList = s.SerializeObject<CListO<Path>>(resourceList, name: "resourceList");
				resourceTypeList = s.SerializeObject<CListP<uint>>(resourceTypeList, name: "resourceTypeList");
				animAABB = s.SerializeObject<AABB>(animAABB, name: "animAABB");
				nameId = s.SerializeObject<CListP<uint>>(nameId, name: "nameId");
				nameResIdx = s.SerializeObject<CListP<int>>(nameResIdx, name: "nameResIdx");
			} else {
				animations = s.SerializeObject<CListO<SubAnim_Template>>(animations, name: "animations");
				banksChangeId = s.SerializeObject<CListO<BankIdChange>>(banksChangeId, name: "banksChangeId");
				animPackage = s.SerializeObject<AnimResourcePackage>(animPackage, name: "animPackage");
				ignoreTexturesLoading = s.Serialize<bool>(ignoreTexturesLoading, name: "ignoreTexturesLoading");
			}
		}
	}
}

