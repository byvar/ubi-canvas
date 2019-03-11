using UnityEngine;

namespace UbiArt.online {
	public partial class GameServerConfig_Template : ITF.TemplateObj {
		[Serialize("NodeJsUrl"                          )] public string NodeJsUrl;
		[Serialize("DefaultRequestOptions"              )] public RequestOptions DefaultRequestOptions;
		[Serialize("VerboseRequestOptions"              )] public RequestOptions VerboseRequestOptions;
		[Serialize("SilentRequestOptions"               )] public RequestOptions SilentRequestOptions;
		[Serialize("facebookPageURL"                    )] public string facebookPageURL;
		[Serialize("CommunityChannelURL"                )] public string CommunityChannelURL;
		[Serialize("crossPromoMaxDisplayCountTotal"     )] public uint crossPromoMaxDisplayCountTotal;
		[Serialize("crossPromoMaxDisplayCountWeekly"    )] public uint crossPromoMaxDisplayCountWeekly;
		[Serialize("crossPromoMinAdventure"             )] public uint crossPromoMinAdventure;
		[Serialize("crossPromoMinDelay"                 )] public uint crossPromoMinDelay;
		[Serialize("CancelAndFailOperationsOnForeground")] public bool CancelAndFailOperationsOnForeground;
		[Serialize("CheckOperationCountDelay"           )] public float CheckOperationCountDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(NodeJsUrl));
			SerializeField(s, nameof(DefaultRequestOptions));
			SerializeField(s, nameof(VerboseRequestOptions));
			SerializeField(s, nameof(SilentRequestOptions));
			SerializeField(s, nameof(facebookPageURL));
			SerializeField(s, nameof(CommunityChannelURL));
			SerializeField(s, nameof(crossPromoMaxDisplayCountTotal));
			SerializeField(s, nameof(crossPromoMaxDisplayCountWeekly));
			SerializeField(s, nameof(crossPromoMinAdventure));
			SerializeField(s, nameof(crossPromoMinDelay));
			SerializeField(s, nameof(CancelAndFailOperationsOnForeground));
			SerializeField(s, nameof(CheckOperationCountDelay));
		}
		public override uint? ClassCRC => 0x56AE7399;
	}
}

