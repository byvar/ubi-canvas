using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class SubAnimSet_Template : CSerializable {
		[Serialize("animations"                   )] public CList<SubAnim_Template> animations;
		[Serialize("banksChangeId"                )] public CList<BankIdChange> banksChangeId;
		[Serialize("animPackage"                  )] public AnimResourcePackage animPackage;
		[Serialize("ignoreTexturesLoading"        )] public bool ignoreTexturesLoading;
		[Serialize("banks"           )] public CList<BankChange_Template> banks;
		[Serialize("skipFiles"       )] public CList<string> skipFiles;
		[Serialize("redirectDone"    )] public int redirectDone;
		[Serialize("resourceList"    )] public CList<Path> resourceList;
		[Serialize("resourceTypeList")] public CList<uint> resourceTypeList;
		[Serialize("animAABB"        )] public AABB animAABB;
		[Serialize("nameId"          )] public CList<uint> nameId;
		[Serialize("nameResIdx"      )] public CList<int> nameResIdx;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(animations));
				SerializeField(s, nameof(banks));
				SerializeField(s, nameof(skipFiles));
				SerializeField(s, nameof(redirectDone));
				SerializeField(s, nameof(resourceList));
				SerializeField(s, nameof(resourceTypeList));
				SerializeField(s, nameof(animAABB));
				SerializeField(s, nameof(nameId));
				SerializeField(s, nameof(nameResIdx));
			} else {
				SerializeField(s, nameof(animations));
				SerializeField(s, nameof(banksChangeId));
				SerializeField(s, nameof(animPackage));
				SerializeField(s, nameof(ignoreTexturesLoading));
			}
		}
	}
}

